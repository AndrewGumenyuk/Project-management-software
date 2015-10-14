using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.ServerService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] _servicesToRun;
            _servicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(_servicesToRun);
        }
    }
}
