using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        abstract class Oddzial
        {
            public abstract string nazwa { get; set; }
        }
        class Wewnetrzny : Oddzial
        {
            private string _nazwa;
            public override string nazwa { get { return _nazwa; } set { _nazwa = value; } }
        }
        class Zakazny : Oddzial
        {
            private string _nazwa;
            public override string nazwa { get { return _nazwa; } set { _nazwa = value; } }
        }
        abstract class Specjalista
        {
            private string _nazwa;
            public string nazwa { get { return _nazwa; } set { _nazwa = value; } }
        }
        abstract class Pracownik
        {
            public string imie { get; set; }
            // kazdy ma swoja specjalizacje
            public Specjalista _specjaliazcja { get; set; }
            // przez abstract, nie kazdy musi miec swoj oddzial
            public abstract Oddzial _oddzial { get; set; }
        }
        class Ordynator : Pracownik
        {
            // w klasie pracownik "abstract" wtedy tutaj musi byc override !
            public override Oddzial _oddzial { get; set; }
            public void PrzedstawSie()
            {
                Console.WriteLine("Jestem {0}, kieruje oddziałem {1}, oraz moja specjalizacja to {2}", imie, _oddzial.nazwa, _specjaliazcja.nazwa);
            }
        }
        class Lekarz : Pracownik
        {
            public override Oddzial _oddzial { get { return null; } set { value = null; } }
            public void PrzedstawSie()
            {
                Console.WriteLine("Jestem {0} moja specjalizacja to {1}", imie, _specjaliazcja.nazwa);
            }
        }
        class Kardiolog : Specjalista
        {
        }
        class Pediatra : Specjalista
        {
        }
        static void Main(string[] args)
        {
            Ordynator ord1 = new Ordynator();
            ord1.imie = "Bogdan";
            ord1._oddzial = new Wewnetrzny();
            ord1._oddzial.nazwa = "Oddzial na 1 pietrze";
            ord1._specjaliazcja = new Kardiolog();
            ord1._specjaliazcja.nazwa = "Kardiolog";
            ord1.PrzedstawSie();

            Lekarz lek1 = new Lekarz();
            lek1.imie = "Łukasz";
            lek1._specjaliazcja = new Pediatra();
            lek1._specjaliazcja.nazwa = "Pediatra 1. stopnia";
            lek1.PrzedstawSie();
            Console.ReadKey();
        }
    }
}