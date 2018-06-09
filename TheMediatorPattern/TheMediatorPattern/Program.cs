using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component Cpu = new Component("Cpu");
            Component CpuFan = new Component("CpuFan");
            Component MainFan = new Component("MainFan");
            
            Mediator mediator = new Mediator();
            //mediator.RegisterComponent(Cpu);
            //mediator.RegisterComponent(CpuFan);
            //mediator.RegisterComponent(MainFan);
            String m = "Increase frequency of rotation.";
            String done = "Done!";
            Cpu.Send(m, ref mediator, ref CpuFan);
            Cpu.Send(m, ref mediator, ref MainFan);
            CpuFan.Send(done, ref mediator, ref Cpu);
            MainFan.Send(done, ref mediator, ref Cpu);

            foreach(var x in CpuFan.Messages)
            { Console.WriteLine(x); }
        }
    }
}
