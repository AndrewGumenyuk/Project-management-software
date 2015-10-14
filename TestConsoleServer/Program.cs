using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using ProjectManager.Common.DAL.Repositories;
using ProjectManager.Entity;
using ProjectManager.IoCManager;

namespace TestConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IoCManager.Start();

            var rep = IoCManager.Kernel.Get<IUserRepository>();

            //rep.Add(new ApplicationUser() {Name = "Kolya", NickName = "Kolyan"});
            //rep.Save();
            Console.WriteLine(rep.GetBy(u => u.Name == "Vasya").First().NickName);
            Console.ReadLine();
            IoCManager.Stop();
        }
    }
}
