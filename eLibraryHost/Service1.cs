using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceProcess;

namespace eLibraryHost
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.IO.File.AppendAllText("C:\\eLibraryHostLog.txt", "eLibraryHost STARTED AT" + DateTime.Now.ToString() + Environment.NewLine);
            this.DoRemoteCongifuration();
        }

        protected override void OnStop()
        {
            System.IO.File.AppendAllText("C:\\eLibraryHostLog.txt", "eLibraryHost STOPPED AT" + DateTime.Now.ToString() + Environment.NewLine);
        }

        private void DoRemoteCongifuration()
        {
            TcpServerChannel channel = new TcpServerChannel(8089);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ELibraryServer.DataAccessLibrary), "ELibraryServer.rem", WellKnownObjectMode.SingleCall);
        }
    }
}
