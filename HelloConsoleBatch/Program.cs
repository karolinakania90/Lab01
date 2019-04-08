using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)

        {
            if (args.Length == 2)
            {
                string imie = args[0];
                string nazwisko = args[1];

                Console.WriteLine("Witaj {0} {1}", imie, nazwisko);


            }
            else if (args.Length >= 3)
            {
                Console.WriteLine("Program na powitanie.");
                Console.Write("podaj imię: ");
                string imie = args[0];

                Console.Write("podaj nazwisko: ");
                string nazwisko = args[1];

                Console.WriteLine("Witaj" + imie + "" + nazwisko);
                Console.WriteLine("Witaj {0} {1}. Czy Pan/i {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

                int wiek = Convert.ToInt32(args[2]);

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
            else
            {
                Console.WriteLine("Brak danych");
                Console.Read();
            }
        }
    }
}
