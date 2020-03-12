using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Cliente
{
    public partial class Form1 : Form
    {
        string ip_server = "127.0.0.1";
        string msg;
        string userMsg;
        int puerto = 31416;
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
        IPEndPoint ie;
        Socket socket;
        NetworkStream networkStream;
        StreamReader sr;
        StreamWriter sw;
        CambiarServidor cambiarServidor;
        public Form1()
        {
            InitializeComponent();
            actualizarLabels();
        }
        public void actualizarLabels()
        {
            labelIp.Text = "Ip: "+ip_server;
            labelPuerto.Text = "Puerto: " + puerto;
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
            try{ 
                msg = sr.ReadLine();
                System.Diagnostics.Debug.WriteLine(msg);
                //Console.WriteLine(msg);
                resultado.Text = msg;
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show("Se ha producido un error con el servidor", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void peticionYcierre(string peticion){
            sw.WriteLine(peticion);
            sw.Flush();
            msg = sr.ReadLine();
            resultado.Text = msg;
            sr.Close();
            sw.Close();
            networkStream.Close();
            socket.Close();
        }

        private void Click(object sender, EventArgs e)
        {
            if (iniciarConexion())
            {
                peticionYcierre((string)((Button)sender).Tag);
            }
        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            cambiarServidor = new CambiarServidor(ip_server, puerto.ToString());
            cambiarServidor.ShowDialog();
            if (DialogResult.OK== cambiarServidor.DialogResult)
            {
                try{
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
                catch (System.FormatException error)
                {
                    MessageBox.Show("No se ha podido cambiar el formato incorrecto", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.OverflowException error)
                {
                    MessageBox.Show("No se ha podido cambiar el valor del puerto tiene que ser ente 0 y 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            actualizarLabels();
        }
    }
}
