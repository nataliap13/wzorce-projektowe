using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Strategia – czynnościowy wzorzec projektowy, który definiuje rodzinę wymiennych algorytmów
 i kapsułkuje je w postaci klas. Umożliwia wymienne stosowanie każdego z nich
 w trakcie działania aplikacji niezależnie od korzystających z nich użytkowników.
     */
namespace TheStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student anna = new Student("Anna", 20);
            Student beata = new Student("Beata", 25);
            Student cezary = new Student("Cezary", 35);
            Student dominik = new Student("Dominik", 40);

            StudentValidator oldValid = new OverAgeStudentValidator(30);

            Course eldersCourse = new Course(oldValid);

            eldersCourse.AddParticipant(anna);
            eldersCourse.AddParticipant(beata);
            eldersCourse.AddParticipant(cezary);
            eldersCourse.AddParticipant(dominik);

            Console.WriteLine("=== Kurs seniorow ===");
            foreach(var x in eldersCourse.Participants)
            { Console.WriteLine(x.Name + "   \t" + x.Age); }

            Console.ReadLine();
        }
    }
}
