using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaServicio2
{
    public partial class UnServicioDePrueba2 : ServiceBase
    {
        public UnServicioDePrueba2()
        {
            InitializeComponent();
        }
        private Thread hilo;
        private Echo servicio;
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
            servicio = new Echo(1);
            servicio.escribeEvento("Entramos en el On Start");
            hilo = new Thread(servicio.inicioServidorEcho);
            hilo.IsBackground = true;
            hilo.Start();
        }

        protected override void OnStop()
        {
            // hilo.Abort();
            servicio.salir = true;
        }
        protected override void OnPause()
        {
            servicio.pausa = true;
        }
        protected override void OnContinue()
        {
            servicio.pausa = false;
            servicio.espera.Set();
        }

    }
}
