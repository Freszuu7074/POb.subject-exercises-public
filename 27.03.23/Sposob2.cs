using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        abstract class Pracownik
        {
            public string imie { get; set; }
            public string Specjalizacja { get; set; }
        }
        abstract class OrdynatorAbstract : Pracownik
        { 
            public abstract string KierowanyOddzial { get; set; }
        }
        class Ordynator : OrdynatorAbstract
        {
            public override string KierowanyOddzial { get; set; }
            public void PrzedstawSie()
            {
                Console.WriteLine("Jestem {0}, kieruje oddzia³em {1}, a moja specjalizacja to {2}",imie,KierowanyOddzial,Specjalizacja);
            }
        }
        class Lekarz : Pracownik
        {
            public void PrzedstawSie()
            {
                Console.WriteLine("Jestem {0}, a moja specjalizacja to {1}",imie,Specjalizacja);
            }
        }
        static void Main(string[] args)
        {
            Ordynator ord1 = new Ordynator();
            ord1.imie = "Bogdan";
            ord1.KierowanyOddzial = "WEWNÊTRZNY 1";
            ord1.Specjalizacja = "SUPER KARDIOLOG";
            ord1.PrzedstawSie();

            Lekarz lk1 = new Lekarz();
            lk1.imie = "£ukasz";
            lk1.Specjalizacja = "Pediatra 1 stopnia";
            lk1.PrzedstawSie();

            Console.ReadKey();
        }
    }
}