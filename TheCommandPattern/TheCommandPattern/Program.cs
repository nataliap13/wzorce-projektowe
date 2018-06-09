using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            {
                int i = 0;
                Calculator<int> calc = new Calculator<int>();
                calc.Calculate(new AddCommand<int>(2));
                Console.WriteLine(i++ + " " + calc.Value);
                calc.Calculate(new AddCommand<int>(10));
                Console.WriteLine(i++ + " " + calc.Value);
                calc.Save();
                Console.WriteLine("Wykonanie kopii aktualnych obliczeń");

                calc.Reverse();
                Console.WriteLine("Cofamy jedno obliczenie.");
                Console.WriteLine(i++ + " " + calc.Value);

                calc.Reverse();
                Console.WriteLine("Cofamy jedno obliczenie.");
                Console.WriteLine(i++ + " " + calc.Value);

                calc.Restore(0);
                Console.WriteLine("Przywrocenie zapisu");
                Console.WriteLine(i++ + " " + calc.Value);

                calc.Reverse();
                Console.WriteLine("Cofamy jedno obliczenie.");
                Console.WriteLine(i++ + " " + calc.Value);

                calc.Reverse();
                Console.WriteLine("Cofamy jedno obliczenie.");
                Console.WriteLine(i++ + " " + calc.Value);

                calc.Reverse();
                Console.WriteLine("Cofamy jedno obliczenie.");
                Console.WriteLine(i++ + " " + calc.Value);
            }
            //catch (Exception e)
            //{ Console.WriteLine(e.Message); }
        }
    }
}
