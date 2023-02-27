using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Osoba
        {
            public string imie { get; set; }
            public string naziwsko { get; set; }
            public string stanowisko { get ; set; }
        }
        class Kierownik : Osoba
        {
            public void zlec_usluge()
            {
                Console.WriteLine();
            }
            public void zamow_czesc()
            {
                Console.WriteLine();
            }
            public void konserwuj_maszyne(Maszyna maszyna)
            {
                Console.WriteLine();
                maszyna.stan_techniczny = true;
            }
        }
        class Spawacz : Osoba
        {
            public void stworz_product()
            {
                Console.WriteLine();
            }
        }
        class Zasob
        {
            public string nazwa_zasobu;
            public int ilosc_zasobu;
        }
        class Czesci : Zasob
        {
            public string nazwa_czesci;
            public int ilosc_czesci;
        }
        class Maszyna : Zasob
        {
            public bool stan_techniczny = false;
        }
        static void Main(string[] args)
        {
        }
    }
}
