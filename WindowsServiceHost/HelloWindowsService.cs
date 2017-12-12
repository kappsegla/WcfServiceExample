using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WindowsServiceHost
{
    public partial class HelloWindowsService : ServiceBase
    {
        ServiceHost host;
        EventLog eventlog;

        public HelloWindowsService()
        {
            InitializeComponent();
            eventlog = new EventLog();
            //this.AutoLog = false;
            
            eventlog.Source = "HelloWindowsService";
            eventlog.Log = "";
        }

        protected override void OnStart(string[] args)
        {
            eventlog.WriteEntry("This is a test log message from OnStart");
            host = new ServiceHost(typeof(WcfServiceLibrary1.Service1));
            host.Open();
        }
       
        protected override void OnStop()
        {
            if(host != null)
             host.Close();
        }

        protected override bool OnPowerEvent(PowerBroadcastStatus powerStatus)
        {
            return base.OnPowerEvent(powerStatus);
        }

    }
}
