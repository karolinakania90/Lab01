using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Program na powitanie.");
            Console.Write("podaj imię: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("podaj nazwisko: ");
            string nazwisko;
            nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj" + imie + "" + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan/i {0} rzeczywiście nazywa się {1}?", imie, nazwisko);


            Console.Write("Podaj wiek ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if (wiek < 67)
            {
                Console.WriteLine(" do emerytury zostało ci {0} lat", 67 - wiek);
            }
            else
            {
                Console.WriteLine("jesteś emerytem");
            }

            Console.Read();
        }
    }
}
