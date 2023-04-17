using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _17._04._23
{
    internal class Program
    {
        abstract class AbstractOsoba
        {
            abstract public string imie { get; set; }
            abstract public string Przedstaw();
        }
        abstract class AbstractOcena
        {
            public string wartosc { get; set; }
        }
        class Nauczyciel : AbstractOsoba
        {
            List<Stopien> stopnie = new List<Stopien>();
            public override string imie { get; set; }
            public override string Przedstaw() { return "7074"; }
            public void dodajOcene(Stopien st)
            {
                stopnie.Add(st);
            }
            public void pokazOceny()
            {
                foreach (var item in stopnie)
                {
                    Console.Write(item.wartosc+" ");
                }
            }
        }
        class Rodzic : AbstractOsoba, IUsprawiedliw
        {
            public override string imie { get; set; }
            public override string Przedstaw() { return "420"; }
            public void usprawiedliwUcznia() { }
        }
        class Uczen : AbstractOsoba
        {
            public override string imie { get; set; }
            public override string Przedstaw() { return "kczd"; }
        }
        abstract class AbstractAdmin : AbstractOsoba
        {

        }
        class Wychowawca : AbstractAdmin, IZwolnij
        {
            public override string imie { get; set; }

            public void akceptujZwolnienie() { }
            public override string Przedstaw() { return "60"; }
        }
        class Stopien : AbstractOcena, IWagaOceny
        {
            public void dajWage() { }
        }
        class Opisowa : AbstractOcena { }
        interface IWagaOceny
        {
            void dajWage();
        }
        interface IUsprawiedliw
        {
            void usprawiedliwUcznia();
        }
        interface IZwolnij
        {
            void akceptujZwolnienie();
        }
        static void Main(string[] args)
        {
            Nauczyciel nau1 = new Nauczyciel();
            Console.WriteLine(nau1.Przedstaw());

            Stopien stop1 = new Stopien();
            stop1.wartosc = "5";
            nau1.dodajOcene(stop1);
            nau1.dodajOcene(stop1);
            nau1.pokazOceny();

            Console.ReadKey();
        }
    }
}
