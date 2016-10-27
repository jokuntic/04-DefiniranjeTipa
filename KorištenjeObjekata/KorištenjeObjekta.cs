using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public class KorištenjeObjekata
    {
        // Ispisati trenutni datum i vrijeme pomoću statičkog svojstva DateTime.Now
        public static void IspišiTrenutniDatumVrijeme()
        {
            Console.WriteLine(DateTime.Now);
        }

        // Ispisati današnji datum pomoću statičkog svojstva DateTime.Now i metode DateTime.ToShortDateString
        public static void IspišiDanašnjiDatum()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        // Ispisati trenutno vrijeme pomoću statičkog svojstva DateTime.Now i metode DateTime.ToShortTimeString
        public static void IspišiTrenutnoVrijeme()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static int IzračunajBrojDanaIzmeđuDvaDatuma(int godina1, int mjesec1, int dan1, int godina2, int mjesec2, int dan2)
        {
            // Stvoriti objekt "datum1" tipa DateTime tako da se njegovom konstruktoru proslijede godina1, mjesec1 i dan1.
            DateTime datum1 = new DateTime(godina1,mjesec1,dan1);
            // Stvoriti objekt "datum2" tipa DateTime tako da se njegovom konstruktoru proslijede godina2, mjesec2 i dan2.
            DateTime datum2 = new DateTime(godina2, mjesec2, dan2);
            // Izračunati razliku između datum1 i datum2 (jednostavnim oduzimanjem: datum2 - datum1) i tu razliku dodijeliti varijabli "period" tipa TimeSpan (koja služi za pohranu vremenskog perioda).
            TimeSpan period = datum2 - datum1;
            // Budući da metoda mora kao rezultat vratiti izračunati period izražen kao broj dana, iz prethodno izračunatog perioda treba dohvatiti i vratiti svojstvo Days (tj. svojstvo TimeSpan.Days).
            return period.Days;
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hr");

            IspišiTrenutniDatumVrijeme();

            IspišiDanašnjiDatum();

            IspišiTrenutnoVrijeme();

            Console.WriteLine(IzračunajBrojDanaIzmeđuDvaDatuma(2015, 5, 1, 2016, 5, 1));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

    }
}
