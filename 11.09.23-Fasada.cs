using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SprawdzDostepnoscLoginu 
    {
        public void sprawdz()
        {
            Console.WriteLine("Login dostępny");
        }
    }
    class DodanieDoBazy 
    {
        public void dodajdobazy()
        {
            Console.WriteLine("Dodano do bazy");
        }
    }
    class DodanieDoRejestruCO2
    {
        public void dodajdorejestru()
        {
            Console.WriteLine("Dodano do rejestru CO2");
        }
    }
    class WpiszDoNewslettera
    {
        public void wpisz()
        {
            Console.WriteLine("Wpisano do newslettera");
        }
    }
    class Rejestracja
    {
        string login, haslo;
        public static void rejestruj()
        {
            SprawdzDostepnoscLoginu sprawdz = new SprawdzDostepnoscLoginu();
            DodanieDoBazy dodajdobazy = new DodanieDoBazy();
            DodanieDoRejestruCO2 dodajdorejestru = new DodanieDoRejestruCO2();
            WpiszDoNewslettera wpisz = new WpiszDoNewslettera();
            sprawdz.sprawdz();
            dodajdobazy.dodajdobazy();
            dodajdorejestru.dodajdorejestru();
            wpisz.wpisz();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rejestracja.rejestruj();
            Console.ReadKey();
        }
    }
}
