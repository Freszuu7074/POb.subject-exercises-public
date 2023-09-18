using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._09._23
{
    internal class Program
    {
        interface IRabatable
        {
            void rabat();
        }
        interface IWysylkable
        {
            void paczkomat();
        }
        class Magazynier
        {
            public static void TowarFasada()
            {
                Rodzaj rodzaj = new Rodzaj();
                Polka polka = new Polka();
                Seria seria = new Seria();
                rodzaj.mrodzaj();
                polka.mpolka();
                seria.mseria();
            }
        }
        class Towar : IRabatable, IWysylkable
        {
            private Seria seria;
            private Rodzaj rodzaj;
            private Polka polka;
            public void rabat()
            {
                Rabat rabat = new Rabat();
                rabat.mrabat();
            }
            public void paczkomat()
            {
                Paczkomat paczkomat = new Paczkomat();
                paczkomat.mpaczkomat();
            }
        }
        class Rodzaj
        {
            string rodzaj = "Mebel";
            public void mrodzaj()
            {
                Console.WriteLine("Rodzaj: "+rodzaj);
            }
        }
        class Polka
        {
            int polka = 76;
            public void mpolka()
            {
                Console.WriteLine("Półka: "+polka);
            }
        }
        class Seria
        {
            string seria = "JD420";
            public void mseria()
            {
                Console.WriteLine("Seria: "+seria);
            }
        }
        class Rabat
        {
            bool promocja = false;
            bool dlabeneficiarzy = false;
            bool zpapieru = true;
            public void mrabat()
            {
                Console.WriteLine("Promocja?: "+promocja);
                Console.WriteLine("Dla beneficiarzy?: "+dlabeneficiarzy);
                Console.WriteLine("Z papieru?: "+zpapieru);
            }
        }
        class Paczkomat
        {
            bool paczkomat = false;
            public void mpaczkomat()
            {
                Console.WriteLine("Można na paczkomat?: "+paczkomat);
            }
        }
        static void Main(string[] args)
        {
            Magazynier.TowarFasada();
            IRabatable rabat = new Towar();
            rabat.rabat();
            IWysylkable paczkomat = new Towar();
            paczkomat.paczkomat();
            Console.ReadKey();
        }
    }
}
