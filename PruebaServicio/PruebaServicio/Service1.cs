using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PruebaServicio
{
    public partial class ServicioSimple : ServiceBase
    {

        private int tiempo = 0;
        public ServicioSimple()
        {
            InitializeComponent();
        }
        public void escribeEvento(string mensaje)
        {
            string nombre = "Servidor Simple";
            string logDestino = "Application";
            if (!EventLog.SourceExists(nombre))
            {
                EventLog.CreateEventSource(nombre, logDestino);
            }
            EventLog.WriteEntry(nombre, mensaje);
        }

        protected override void OnStart(string[] args)
        {
            escribeEvento("Ejecutando OnStart");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 10000; // cada 10 segundos
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }
        
        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            escribeEvento(string.Format("Servicio en ejecución durante {0} segundos",
            tiempo));
            tiempo += 10;
        }
        protected override void OnStop()
        {
            escribeEvento("Deteniendo servicio");
            tiempo = 0;
        }

        protected override void OnPause()
        {
            escribeEvento("Servicio en Pausa");
        }
        protected override void OnContinue()
        {
            escribeEvento("Continuando servicio");
        }
    }
}
