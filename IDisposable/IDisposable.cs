using System;
using System.IO;

namespace Vsite.CSharp
{
    public class Disposable
    {
        public static void StvaranjeIPisanjeUDatoteku(string imeDatoteke)
        {
            StreamWriter sw = new StreamWriter(imeDatoteke);
            sw.WriteLine("Ovo je moj upis");
            //  Pokrenuti program i pogledati ispis.

            //  Dodati poziv metode StreamWriter.Dispose (ili StreamWriter.Close) te ponovno pokrenuti program.
            // sw.Dispose();
            //  Preraditi kod metode tako da se umjesto metode Dispose koristi blok using
            sw.Close();
        }

        public static void BrisanjeDatoteke(string imeDatoteke)
        {
            File.Delete(imeDatoteke);
        }


        static void Main(string[] args)
        {
            try
            {
                StvaranjeIPisanjeUDatoteku("moj.txt");
                Console.WriteLine("Brišem datoteku");
                BrisanjeDatoteke("moj.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
