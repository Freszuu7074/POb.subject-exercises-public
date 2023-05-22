using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Program
    {
        public abstract class Figura
        {
            public abstract double Obwod();
            public abstract double PolePowierzchni();
            public abstract double SumaKatow();
            public abstract double PromienOkreguWpisanego();
        }
        public class Trojkat : Figura
        {
            private double bok;
            public Trojkat(double bok)
            {
                this.bok = bok;
            }
            public override double Obwod()
            {
                return 3 * bok;
            }
            public override double PolePowierzchni()
            {
                return (Math.Sqrt(3) / 4)*bok*bok;
            }
            public override double SumaKatow()
            {
                return 180;
            }
            public override double PromienOkreguWpisanego()
            {
                return bok / (2 * Math.Sqrt(3));
            }
        }
        public class Kwadrat : Figura
        {
            private double bok;
            public Kwadrat(double bok)
            {
                this.bok = bok;
            }
            public override double Obwod()
            {
                return 4 * bok;
            }
            public override double PolePowierzchni()
            {
                return bok * bok;
            }
            public override double SumaKatow()
            {
                return 360;
            }
            public override double PromienOkreguWpisanego()
            {
                return bok / 2;
            }
        }
        class PieciokatForemny : Figura
        {
            private double bok;
            public PieciokatForemny(double bok)
            {
                this.bok = bok;
            }
            public override double Obwod()
            {
                return 5 * bok;
            }
            public override double PolePowierzchni()
            {
                return (Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4) * bok * bok;
            }
            public override double SumaKatow()
            {
                return 540;
            }
            public override double PromienOkreguWpisanego()
            {
                return bok * Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 10;
            }
        }
        public class SzesciokatForemny : Figura
        {
            private double bok;
            public SzesciokatForemny(double bok)
            {
                this.bok = bok;
            }
            public override double Obwod()
            {
                return 6 * bok;
            }
            public override double PolePowierzchni()
            {
                return (3 * Math.Sqrt(3) / 2) * bok * bok;
            }
            public override double SumaKatow()
            {
                return 720;
            }
            public override double PromienOkreguWpisanego()
            {
                return bok * Math.Sqrt(3) / 2;
            }
        }
        static void Main(string[] args)
        {
            Figura trójkąt = new Trojkat(5);
            Figura kwadrat = new Kwadrat(4);
            Figura pięciokątForemny = new PieciokatForemny(6);
            Figura sześciokątForemny = new SzesciokatForemny(7);

            Console.WriteLine("Trójkąt:");
            Console.WriteLine("Obwód: " + trójkąt.Obwod());
            Console.WriteLine("Pole powierzchni: " + trójkąt.PolePowierzchni());
            Console.WriteLine("Suma kątów: " + trójkąt.SumaKatow());
            Console.WriteLine("Promień okręgu wpisanego: " + trójkąt.PromienOkreguWpisanego());
            Console.WriteLine();

            Console.WriteLine("Kwadrat:");
            Console.WriteLine("Obwód: " + kwadrat.Obwod());
            Console.WriteLine("Pole powierzchni: " + kwadrat.PolePowierzchni());
            Console.WriteLine("Suma kątów: " + kwadrat.SumaKatow());
            Console.WriteLine("Promień okręgu wpisanego: " + kwadrat.PromienOkreguWpisanego());
            Console.WriteLine();

            Console.WriteLine("Pięciokąt foremny:");
            Console.WriteLine("Obwód: " + pięciokątForemny.Obwod());
            Console.WriteLine("Pole powierzchni: " + pięciokątForemny.PolePowierzchni());
            Console.WriteLine("Suma kątów: " + pięciokątForemny.SumaKatow());
            Console.WriteLine("Promień okręgu wpisanego: " + pięciokątForemny.PromienOkreguWpisanego());
            Console.WriteLine();

            Console.WriteLine("Sześciokąt foremny:");
            Console.WriteLine("Obwód: " + sześciokątForemny.Obwod());
            Console.WriteLine("Pole powierzchni: " + sześciokątForemny.PolePowierzchni());
            Console.WriteLine("Suma kątów: " + sześciokątForemny.SumaKatow());
            Console.WriteLine("Promień okręgu wpisanego: " + sześciokątForemny.PromienOkreguWpisanego());

            Console.ReadKey();
        }
    }
}
