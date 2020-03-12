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

namespace Servicio1
{
    public partial class UnServicioDeTiempo : ServiceBase
    {
        Servidor server=new Servidor();
        public UnServicioDeTiempo()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            new Thread(()=>{server.IniciarServer();}).Start();
        }

        protected override void OnStop()
        {
            //server.encendido = false;
            server.cerrarServidor();
        }
    }
}
