using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        //  Prekopirati definiciju klase s destruktorom iz prethodnog primjera
        //  Staviti točku prekida (breakpoint) u destruktor, pokrenuti program i pogledati zadnje ispise prije prekida izvođenja.
        public class KlasaSDestruktorom
        {
            
                public KlasaSDestruktorom()
                {
                    RedniBroj = ++Brojač;
                    string poruka = string.Format("Konstruktor objekta br. {0}", RedniBroj);
                    // ispis u konzolu
                    Console.WriteLine(poruka);
                    // dijagnostički ispis u Output prozor Visual Studija
                    Debug.WriteLine(poruka);
                }

                //  Dodati destruktor (tj. finalizirajuću metodu) i njemu napisati naredbe koje će u konzolu i u Output prozor ispisati: "Destruktor objekta br. {RedniBroj}."
                ~KlasaSDestruktorom()
                {
                    Console.WriteLine($"Destruktor objekta br. {RedniBroj}");
                    Debug.WriteLine($"Destruktor objekta br. { RedniBroj}");
                }


                public readonly int RedniBroj; // redni broj objekta

                static int Brojač = 0; // brojač ukupno stvorenih objekata
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");

            for (int i = 0; i < 1000; i++)
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            Console.WriteLine("*** Pozivamo GC.Collect() ***");
            Debug.WriteLine("*** Pozivamo GC.Collect() ***");

            // explicitno pozivamo sustav za skupljanje smeća
            // redoslijed uništavanja objekata nije unaprijed određen!
            GC.Collect();

            Debug.WriteLine("*** GOTOVO!!! ***");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Debug.WriteLine("*** SADA JE KONAČNO!!! ***");
        }
    }
}
