using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) // view proces
        {
            Process[] procesos = Process.GetProcesses();
            textBox1.Text = "";
            textBox1.Text += String.Format("{0,-10}{1,-40}{2,-25}\r\n", "PID", "Name", "TVentana");
            foreach (Process proceso in procesos) {
                try
                {
                    string nproceso = proceso.ProcessName;

                    textBox1.Text += String.Format("{0,-10}{1,-40}", proceso.Id, nproceso);
                    if (proceso.MainWindowTitle != "")
                    {
                        String ventana = proceso.MainWindowTitle;
                        if (ventana.Length > 22)
                        {
                            ventana = ventana.Substring(0, 21) + "...";
                        }
                        textBox1.Text += String.Format("{0,-25}", ventana);
                    }
                    textBox1.Text += "\r\n";
                }
                catch(System.ComponentModel.Win32Exception error)
                {

                }
            //Console.WriteLine("Name: {0}\nPID: {1}\nSubprocesses: {2}\nInit: {3}", proceso.ProcessName, proceso.Id, proceso.Threads.Count, proceso.StartTime);
        }
        }

        private void Button2_Click(object sender, EventArgs e) //proces info
        {
            Process proceso= new Process();
            try
            {
                proceso = Process.GetProcessById(Convert.ToInt32(textBox2.Text));
                textBox1.Text = string.Format("PID:{0,-7}\tName: {1,-15}\tTstart: {2,-10}\r\nLista de modulos:\r\n", proceso.Id, proceso.ProcessName, proceso.StartTime);
                ProcessModuleCollection modulos = proceso.Modules;
                textBox1.Text +=  string.Format("{0,-20}{1,-50}\r\n","Nombre del modulo","Ventana");
                foreach (ProcessModule a in modulos)
                {
                    String mname = a.ModuleName;
                    String fname = a.FileName;
                    if (mname.Length > 20)
                    {
                        mname = mname.Substring(0, 17) + "...";
                    }
                    if (fname.Length > 80)
                    {
                        fname = fname.Substring(0, 50) + "...";
                    }
                    textBox1.Text += string.Format("{0,-20}{1,-80}\r\n", mname,fname); 
                }
                textBox1.Text += string.Format("Lista de hilos\r\n");
                textBox1.Text += string.Format("{0,-20}{1,-50}\r\n", "Id", "Tstart");
                foreach (ProcessThread a in proceso.Threads)
                {
                    textBox1.Text += string.Format("{0,-20}{1,-50}\r\n", a.Id, a.StartTime);
                } 
                
            }
            catch(FormatException error)
            {
                textBox1.Text ="No existe un proceso con ese PID" ;
            }
            catch (ArgumentException error)
            {
                textBox1.Text = "No existe un proceso con ese PID";
            }catch(OverflowException error)
            {
                textBox1.Text = "Valor numerico demasiado grande";
            }
            catch (Win32Exception error)
            {
                textBox1.Text = "Acceso denegado";
            }
        }

        private void Button3_Click(object sender, EventArgs e) //close
        {
            Process proceso = new Process();
            try
            {
                proceso = Process.GetProcessById(Convert.ToInt32(textBox2.Text));
                proceso.CloseMainWindow();

            }
            catch (FormatException error)
            {
                textBox1.Text = "No existe un proceso con ese PID";
            }
            catch (ArgumentException error)
            {
                textBox1.Text = "No existe un proceso con ese PID";
            }
            catch (OverflowException error)
            {
                textBox1.Text = "Valor numerico demasiado grande";
            }
        }
        private void Button4_Click(object sender, EventArgs e) // kill
        {
            Process proceso = new Process();
            try
            {
                proceso = Process.GetProcessById(Convert.ToInt32(textBox2.Text));
                proceso.Kill();
            }
            catch (FormatException  )
            {
                textBox1.Text = "No existe un proceso con ese PID";
            }
            catch (ArgumentException  )
            {
                textBox1.Text = "No existe un proceso con ese PID";
            }
            catch (OverflowException  )
            {
                textBox1.Text = "Valor numerico demasiado grande";
            }
            catch (Win32Exception  )
            {
                textBox1.Text = "Acceso no permitido";
            }
            
        }

        private void Button5_Click(object sender, EventArgs e) //Run
        {
            try
            {
                Process.Start(textBox2.Text);
            }
            catch (Win32Exception error)
            {
                textBox1.Text = "No se ha podido inializar el proceso";
            }
            catch (InvalidOperationException error)
            {
                textBox1.Text = "No se ha podido inializar el proceso";
            }
        }
    }
}
