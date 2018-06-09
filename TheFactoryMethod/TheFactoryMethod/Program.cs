using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Strategia – czynnościowy wzorzec projektowy, który definiuje rodzinę wymiennych algorytmów
i kapsułkuje je w postaci klas. Umożliwia wymienne stosowanie każdego z nich w trakcie
działania aplikacji niezależnie od korzystających z nich użytkowników.
*/
namespace TheFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sandwich.SandwichFactory(Sandwich.SandwichType.Cheese).GetPrice());
        }
    }
}
