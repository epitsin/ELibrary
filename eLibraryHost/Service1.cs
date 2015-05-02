using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

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
        }

        protected override void OnStop()
        {
            System.IO.File.AppendAllText("C:\\eLibraryHostLog.txt", "eLibraryHost STOPPED AT" + DateTime.Now.ToString() + Environment.NewLine);
        }
    }
}
