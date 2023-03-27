using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Oddzial
    {
        public string Nazwa { get; set; }
    }
    class Wewnetrzny : Oddzial { }
    class Zakazny : Oddzial { }
    class Dzieciecy : Oddzial { }
    abstract class Specjalista
    {
        public abstract string Nazwa { get; set; }
    }
    abstract class Pracownik
    {
        public string Imie { get; set; }
        public Specjalista Specjalizacja { get; set; }
        public abstract Oddzial KierowanyOddzial { get; set; }
    }
    class Ordynator : Pracownik
    {
        public override Oddzial KierowanyOddzial { get { return KierowanyOddzial; } set { KierowanyOddzial = value; } }
        public void PrzedstawSie()
        {
            Console.WriteLine("Jestem {0}, kieruję oddziałem {1}", Imie, KierowanyOddzial.Nazwa);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ordynator ord1 = new Ordynator();
            ord1.Imie = "Bogdan";
            ord1.KierowanyOddzial = new Wewnetrzny();
            ord1.KierowanyOddzial.Nazwa = "Oddział Wewnętrzny 2 piętro";
            ord1.PrzedstawSie();*/

            // StackOverflow

            Console.ReadKey();
        }
    }
}
