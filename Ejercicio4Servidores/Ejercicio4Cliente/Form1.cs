using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Ejercicio4Servidores;
namespace Ejercicio4Cliente
{
    public partial class Form1 : Form
    {
        List<Label> labels = new List<Label>();
        public string ip_server= "127.0.0.1";
        int puerto = 1;
        IPEndPoint ie;
        Socket socket;
        NetworkStream networkStream;
        StreamReader sr;
        StreamWriter sw;
        BinaryFormatter formatter = new BinaryFormatter();
        int segundos;
        string palabra;
        AñadirPalabras añadirPalabras;
        CambiarServidor cambiarServidor;
        String comprobadas= "";
        int Puerto
        {
            set
            {
                if (value >= 0 && value < 65536)
                {
                    puerto = value;
                }
                else
                {
                    throw new OverflowException();
                }
            }
            get { return puerto; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        public bool iniciarConexion()
        {
            try
            {
                ie = new IPEndPoint(IPAddress.Parse(ip_server), this.puerto);
            }
            catch
            {
                MessageBox.Show("Formato de la ip no valido", "Error ip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(ie);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message, "Error:" + e.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            networkStream = new NetworkStream(socket);
            sw = new StreamWriter(networkStream);
            sr = new StreamReader(networkStream);
            try
            {
                String msg = sr.ReadLine();
                System.Diagnostics.Debug.WriteLine(msg);
                //Console.WriteLine(msg);
                //label1.Text = msg;
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Se ha producido un error con el servidor", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public string peticionYcierre(string peticion)
        {
            String msg = null;
            sw.WriteLine(peticion);
            sw.Flush();
            msg = sr.ReadLine();
            sr.Close();
            sw.Close();
            networkStream.Close();
            socket.Close();
            return msg;
        }

        private void Getrecords_Click(object sender, EventArgs e)
        {
            if (iniciarConexion())
            {
                String recordhex= peticionYcierre("getrecords");
                MemoryStream memoryStream = new MemoryStream(Transformaciones.StringToByteArray(recordhex));
                Record []records=(Record[])formatter.Deserialize(memoryStream);
                memoryStream.Close();
                new FormRecords(records).ShowDialog();
            }  
        }
        private void PedirNombre()
        {
            FormNuevoRecord formNuevoRecord = new FormNuevoRecord();
            if (formNuevoRecord.ShowDialog() == DialogResult.OK)
            {
                if (formNuevoRecord.textBox1.Text.Trim() != "")
                {
                    if (iniciarConexion())
                    {
                        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                        string ipLocal = null;
                        foreach (var ip in host.AddressList)
                        {
                            if (ip.AddressFamily == AddressFamily.InterNetwork)
                            {
                                ipLocal = ip.ToString();
                                break;
                            }
                        }
                        MemoryStream memoryStream = new MemoryStream();
                        formatter.Serialize(memoryStream, new Record(formNuevoRecord.textBox1.Text, segundos, ipLocal));
                        peticionYcierre($"sendrecord {Transformaciones.ByteArrayToString(memoryStream.ToArray())}");
                    }
                    else
                    {
                        MessageBox.Show("Has cancelado el envio del record", "Record cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No puedes enviar un nombre en blanco", "Record cancelado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DibujoAhorcado1_CambiaError(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Cambi error");
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            if (iniciarConexion())
            {
                dibujoAhorcado1.Errores = 0;
                comprobadas ="";
                lcomprobados.Text = "";
                labels = new List<Label>();
                for (int i = Controls.Count - 1; i >= 0; i--)
                {
                    if (Controls[i].Name.Contains("AutoGenerado"))
                    {
                        Controls.RemoveAt(i);
                    }
                }
                palabra = peticionYcierre("getword");
                if (palabra != null)
                {
                    palabra = palabra.ToLower();
                    System.Diagnostics.Debug.WriteLine(palabra);
                    segundos = 0;
                    ltiempo.Text = "Tiempo: 00h:00m:00s";
                    timer1.Start();
                    tJugar.Enabled = false;
                    Jugar.Enabled = false;
                    mJugar.Enabled = false;
                    labelLetra.Enabled = true;
                    sendword.Enabled = true;
                    textLetra.Enabled = true;
                    int x = 150;
                    int y = 100;
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        Label label = new Label();
                        label.AutoSize = true;
                        label.Location = new System.Drawing.Point(x, y);
                        label.Name = "AutoGenerado" + i;
                        label.Tag = palabra[i].ToString();
                        label.Size = new System.Drawing.Size(30, 13);
                        label.Text = "_";
                        labels.Add(label);
                        this.Controls.Add(label);
                        x = x + 15;
                    }
                }
                else
                {
                    MessageBox.Show("El servidor no a mandado una palabra", "El servidor mando null", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void terminarPartida()
        {
            timer1.Stop();
            tJugar.Enabled = true;
            Jugar.Enabled = true;
            mJugar.Enabled = true;
            labelLetra.Enabled = false;
            sendword.Enabled = false;
            textLetra.Enabled = false;
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Text = (String)labels[i].Tag;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            TimeSpan tiempo= TimeSpan.FromSeconds(segundos);
            ltiempo.Text = string.Format("Tiempo: {0:D2}h:{1:D2}m:{2:D2}s", tiempo.Hours, tiempo.Minutes, tiempo.Seconds); 
        }

        private void ComprobarLetra(object sender, EventArgs e)
        {
            bool acerto=false;
            if (textLetra.Text != "")
            {
                if (!comprobadas.Contains(textLetra.Text.ToLower()))
                {
                    comprobadas = comprobadas + textLetra.Text.ToLower();
                    lcomprobados.Text = "";
                    foreach (Char letra in comprobadas) {
                        lcomprobados.Text = lcomprobados.Text + letra + " ";
                    }
                }
                for (int i = 0; i < labels.Count; i++)
                {
                    if (textLetra.Text.ToLower() == (String)labels[i].Tag)
                    {
                        labels[i].Text = (String)labels[i].Tag;
                        acerto = true;
                    }
                }
                if (!acerto)
                {
                    dibujoAhorcado1.Errores++;
                }
                else
                {
                    bool fin = true;
                    foreach (Label label in labels)
                    {
                        if (label.Text != (String)label.Tag)
                        {
                            fin = false;
                        }
                    }
                    if (fin)
                    {
                        System.Diagnostics.Debug.WriteLine("Termino");
                        timer1.Stop();
                        if (iniciarConexion())
                        {
                            String recordhex = peticionYcierre("getrecords");
                            MemoryStream memoryStream = new MemoryStream(Transformaciones.StringToByteArray(recordhex));
                            Record[] records = (Record[])formatter.Deserialize(memoryStream);
                            memoryStream.Close();
                            bool mejor = false;
                            foreach (Record record in records)
                            {
                                if (record != null)
                                {
                                    if (record.tiempo > segundos)
                                    {
                                        mejor = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    mejor = true;
                                }
                            }
                            if (mejor)
                            {
                                PedirNombre();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido conetar al servidor para comprobar los recods", "Problema con el servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        tJugar.Enabled = true;
                        Jugar.Enabled = true;
                        mJugar.Enabled = true;
                        labelLetra.Enabled = false;
                        sendword.Enabled = false;
                        textLetra.Enabled = false;
                    }
                }
                textLetra.Text = "";
            }
        }

        private void CancelarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminarPartida();
        }

        private void DibujoAhorcado1_Ahorcado_1(object sender, EventArgs e)
        {
            terminarPartida();
            MessageBox.Show("Has perdido", "Perdiste", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AñadirPalbrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadirPalabras = new AñadirPalabras();
            if(DialogResult.OK== añadirPalabras.ShowDialog())
            {
                string paraAñadir=añadirPalabras.ResultadoFormulario();
                if (paraAñadir!=null )
                {
                    if (paraAñadir.Trim() != "")
                    {
                        if (iniciarConexion())
                        {
                            peticionYcierre("sendword " + paraAñadir);
                        }
                    }
                }
            }
        }

        private void CambiarIpYPuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarServidor = new CambiarServidor(ip_server, puerto.ToString());
            cambiarServidor.ShowDialog();
            if (DialogResult.OK == cambiarServidor.DialogResult)
            {
                try
                {
                    Puerto = Convert.ToInt32(cambiarServidor.port.Text);
                    if (cambiarServidor.ip.Text.Trim() == "")
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        ip_server = cambiarServidor.ip.Text;
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("No se ha podido cambiar el formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.OverflowException)
                {
                    MessageBox.Show("No se ha podido cambiar el valor del puerto tiene que ser ente 0 y 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
