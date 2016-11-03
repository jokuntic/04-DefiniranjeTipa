using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
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

    class Destruktor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            // TODO: Dodati for petlju koja će se ponoviti 100000 puta i unutar koje će se kreirati novi objekti tipa KlasaSDestruktorom. Pokrenuti program i provjeriti redni broj prvog uništenog objekta.
            for (int i = 0; i < 100000; ++i)
            {
                new KlasaSDestruktorom();
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
