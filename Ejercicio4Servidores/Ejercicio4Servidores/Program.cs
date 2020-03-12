using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace Ejercicio4Servidores
{
    [Serializable]
    public class Record
    {
        public string nombre;
        public float tiempo;
        public String ip;
        public Record(string nombre, float tiempo, String ip)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;
            this.ip = ip;
        }
        public bool mejor(Record otro)
        {
            if (this.tiempo > otro.tiempo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public static class Transformaciones{
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }
        public static string ByteArrayToString(byte[] contenido)
        {
            string resultado = null;
            for (int i = 0; i < contenido.Length; i++)
            {
                resultado += contenido[i].ToString("X2");
            }
            return resultado;
        }
    }

    class Program
    {
        static IFormatter formatter=new BinaryFormatter();
        static String patchPalabras = Environment.GetEnvironmentVariable("programdata")+"\\ej4palabras.txt";
        static String patchrecord = Environment.GetEnvironmentVariable("programdata") + "\\ej4records.dat";
        static String patcauxiliar = Environment.GetEnvironmentVariable("programdata") + "\\ej4auxilir.dat";
        static Random generador = new Random();
        static String clave= "123";
        static readonly object l = new object();
        static Socket socketServidor=null;
        static bool salir = false;
        static void Main(string[] args)
        {
            int puerto = 1;
            bool valido=false;
            IPEndPoint ie;
            socketServidor = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            do
            {
                try
                {
                    ie = new IPEndPoint(IPAddress.Any, puerto);
                    socketServidor.Bind(ie);
                    socketServidor.Listen(10);
                    valido = true;
                    Console.WriteLine($"Establecido en el puerto {puerto}");
                }
                catch (SocketException)
                {
                    puerto++;
                }
            } while (!valido);
            FileInfo archivoRecords = new FileInfo(patchrecord);
            if (!archivoRecords.Exists)
            {
                Record[] records = new Record[10];
                for (int i = 0; i < records.Length; i++)
                {
                    records[i] = null;
                }
                guardarRecord(records);
            }
            while (!salir)
            {
                try
                {
                    Socket socketcliente = socketServidor.Accept();
                    Console.WriteLine("Cliente conectado desde " + ((IPEndPoint)socketcliente.RemoteEndPoint).Address);
                    new Thread(hiloCliente).Start(socketcliente);
                }
                catch (System.Net.Sockets.SocketException) // Revisar codigo de error con when
                {
                    
                }
            }
            socketServidor.Close();
            Console.WriteLine("Servidor Cerrado");
        }
        static void guardarRecord(Record record)
        {
            guardarRecord(record, patchrecord);
        }
        static void guardarRecord(Record record, string patchrecord)
        {
            FileInfo archivoRecords = new FileInfo(patchrecord);
            lock (l)
            {
                Stream stream = new FileStream(patchrecord, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, record);
                stream.Close();
            }
        }
        static void guardarRecord(Record[] record)
        {
            if (record.Length == 10)
            {
                FileInfo archivoRecords = new FileInfo(patchrecord);
                lock (l)
                {
                    Stream stream = new FileStream(patchrecord, FileMode.Create, FileAccess.Write);
                    formatter.Serialize(stream, record);
                    stream.Close();
                }
            }
        }
        static void comprobacionNuevoRecord(string nuevorecor)
        {
            try{
                MemoryStream memoryStream = new MemoryStream(Transformaciones.StringToByteArray(nuevorecor));
                Record recor = (Record)formatter.Deserialize(memoryStream);
                memoryStream.Close();
                comprobacionNuevoRecord(recor);
            }
            catch (System.FormatException) { Console.WriteLine("Error de formato al mandar el record"); }
        }
        static void comprobacionNuevoRecord(Record nuevorecor)
        {
            bool mejor = false;
            Record[] records = mandarRecords();
            for (int i=0;i<records.Length ;i++)
            {
                if (records[i] == null)
                {
                    mejor = true;                    
                    records[i] = nuevorecor;
                    i = records.Length;
                }
                else
                {
                    if (records[i].mejor(nuevorecor))
                    {
                        Console.WriteLine(i);
                        for (int j = records.Length - 1; j > i; j--)
                        {
                            records[j] = records[j - 1];
                        }
                        records[i] = nuevorecor;
                        mejor = true;
                        i = records.Length;
                    }
                }
            }
            if (mejor)
            {
                guardarRecord(records);
            }
        }
        static Record[] mandarRecords()
        {
            FileInfo archivoRecords = new FileInfo(patchrecord);
            Record[] records = new Record[10];
            lock (l)
            {
                Stream stream = new FileStream(patchrecord, FileMode.Open,FileAccess.Read);
                records = (Record[])formatter.Deserialize(stream);
                stream.Close();
                return records;
            }
        }
        static string mandarRecordsHexadecimal()
        {
            return mandarRecordsHexadecimal(patchrecord);
        }
        static string mandarRecordsHexadecimal(string patchrecord)
        {
            FileInfo archivoRecords = new FileInfo(patchrecord);
            lock (l)
            {
                return Transformaciones.ByteArrayToString(File.ReadAllBytes(patchrecord));
            }
        }
        static void añadirPalabras(String palabra)
        {
            FileInfo filepalabras = new FileInfo(patchPalabras);
            
            lock (l)
            {
                StreamWriter streamWriter = new StreamWriter(patchPalabras, true);
                Console.WriteLine("Añadiendo palabras");
                if (filepalabras.Length != 0)
                {
                    streamWriter.Write("," + palabra);
                }
                else
                {
                    streamWriter.Write(palabra);
                }
                streamWriter.Close();
            }
        }
        static void añadirPalabras(String[] palabra)
        {
            foreach (string palab in palabra)
            {
                añadirPalabras(palab);
            }
        }
        static string obtenerPalabra()
        {
            FileInfo filepalabras = new FileInfo(patchPalabras);
            string[] palabras;
            Console.WriteLine("Pidiendo palabra");
            lock (l)
            {
                if (filepalabras.Exists)
                {
                    if (filepalabras.Length != 0)
                    {
                        StreamReader streamReader = new StreamReader(patchPalabras, true);
                        palabras = streamReader.ReadToEnd().Split(',');
                        streamReader.Close();
                        String resultado;
                        resultado = palabras[generador.Next(0, palabras.Length)];
                        Console.WriteLine("envia " + resultado);
                        return resultado;
                    }
                    else
                    {
                        Console.WriteLine("Archivo vacio o inexistente se devuelve null");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Archivo vacio o inexistente se devuelve null");
                    return null;
                }
            }
        }
        static void hiloCliente(Object socket)
        {
            Socket socketCliente;
            if(socket is Socket)
            {
                socketCliente = (Socket)socket;
                NetworkStream ns= new NetworkStream(socketCliente);
                StreamWriter sw=new StreamWriter(ns);
                StreamReader sr=new StreamReader(ns);
                sw.WriteLine("Bienvenido haga su peticion");
                sw.Flush();
                switch (sr.ReadLine())
                {
                    case "getword":
                        sw.Write(obtenerPalabra());
                        sw.Flush();
                        break;
                    case string peticion when peticion.Length >= 8 && peticion.Substring(0, 8) == "sendword":
                        String[] palabras = peticion.Substring(8, peticion.Length - 8).Trim().Split(',');
                        //foreach (string palabra in palabras)
                        //{
                            añadirPalabras(palabras);
                        //}
                        break;
                    case "getrecords":
                        sw.Write(mandarRecordsHexadecimal());
                        sw.Flush();
                        break;
                    case string peticion when peticion.Length >= 10 && peticion.Substring(0, 10) == "sendrecord":
                        comprobacionNuevoRecord(peticion.Substring(10, peticion.Length - 10).Trim());
                        break;
                    case string peticion when peticion.Length >= 11 && peticion.Substring(0, 11) =="closeserver":
                        if(clave== peticion.Substring(11, peticion.Length - 11).Trim()) {
                            Console.WriteLine("cerrar");
                            lock(l){
                                salir = true;
                                //(Process.GetCurrentProcess()).Kill();
                                socketServidor.Close();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Clave invalida" + peticion.Substring(11, peticion.Length - 11).Trim());
                        }
                        break;
                }
                //Recor[] records = new Recor[40];
                //for(int i = 0; i < records.Length; i++) {
                //    records[i] = new Recor(i.ToString(),1+i,i.ToString());
                //}
                //Recor[] prueba1 ={ records[10], records[11], records[12], records[13], records[14], records[15], records[16], records[17], records[18], records[19]};
                //guardarRecord(prueba1);
                //comprobacionNuevoRecor(records[4]);
                //comprobacionNuevoRecor(records[9]);
                //comprobacionNuevoRecor(records[5]);
                //MemoryStream ms = new MemoryStream();
                //formatter.Serialize(ms, new Recor("asd", 123f, "sad"));
                //ms.Position = 0;
                //formatter.Deserialize(ms);
                //comprobacionNuevoRecor(Transformaciones.ByteArrayToString(ms.ToArray()));
                sr.Close();
                sw.Close();
                ns.Close();
                socketCliente.Close();
                Console.WriteLine("Cliente fuera");
            }
        }
    }
    
}
