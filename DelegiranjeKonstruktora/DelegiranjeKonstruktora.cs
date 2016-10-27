using System;

namespace Vsite.CSharp
{
    class Bazna
    {
        public Bazna() {
            A = 5;
        }
        protected Bazna(int a) // konstruktor je protected!
        {
            A = a;
            Console.WriteLine(string.Format("Bazna.Bazna({0})", a));
        }

        public readonly int A; //jedino se u konstruktoru može inicijalizirati ili na trenutnom mjestu
    }

    class Izvedena  : Bazna
    {
        public Izvedena() : this(3,5) //this kaže pronađi konstruktor koji prima 2 argumenta i pozovi ga
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena()"));
        }

        public Izvedena(int a,int b) : base(a)
        {
            B = b;
            Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }

        public readonly int B;
    }

    public class DelegiranjeKonstruktora
    {
        public static void StvoriInstancuBazneKlase()
        {
            //  Stvoriti instancu klase Bazna i ispisati vrijednost člana A.
            Bazna b = new Bazna();
            Console.WriteLine(b.A);
        }

        public static void StvoriInstancuIzvedeneKlasePraznimKonstruktorom()
        {
            //  Promijeniti klasu Izvedena tako da je izvedena iz klase Bazna. Provjeriti da li se kod prevodi te napraviti potrebne promjene u klasi Izvedena.
            //  Stvoriti instancu klase Izvedena pozivom podrazumijevanog konstruktora.
            Izvedena i = new Izvedena();
            //  Ispisati vrijednosti članova A i B stvorenog objekta.
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {
            // U klasu Izvedena dodati konstruktor s dva argumenta ("a" i "b") tipa int, kojima će se inicijalizirati članovi A i B. 
            // U tijelo konstruktora dodati naredbu za ispis: Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));

            //  Stvoriti objekt pozivom tog konstruktora i ispisati vrijednosti članova A i B stvorenog objekta.
            Izvedena i = new Izvedena(5, 3);
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
            //  Promijeniti prazni konstruktor klase Izvedena tako da delegira poziv konstruktora s dva argumenta.

        }

        static void Main(string[] args)
        {
            StvoriInstancuBazneKlase();

            StvoriInstancuIzvedeneKlasePraznimKonstruktorom();

            StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }

}
