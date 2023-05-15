using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    { 
        public class Commodity
        {
            public string Name { get; set;}
            public int Price { get; set;}
            public int Amount { get; set;}
            public virtual void Description()
            {
                Console.WriteLine($"Nazwa: {Name}, cena {Price}, ilość {Amount}");
            }
        }
        public class Nails : Commodity
        {
            public int Length { get; set;}
            public int Thickness { get; set;}
            public string Type { get; set;}
            public override void Description()
            {
                base.Description();
                Console.WriteLine($"Długość: {Length}, grubość: {Thickness}, rodzaj łepka: {Type}");
            }
        }
        public class Sandpaper : Commodity
        {
            public string Granularity { get; set; }
            public string Width { get; set; }
            public override void Description()
            {
                base.Description();
                Console.WriteLine($"Ziarnistość {Granularity}, szerokość {Width}");
            }
        }
        public class Furniture : Commodity
        {
            public string Collection { get; set; }
            public override void Description()
            {
                base.Description();
                Console.WriteLine($"Kolekcja: {Collection}");
            }
        }
        static void Main(string[] args)
        {
            Commodity c = new Commodity
            {
                Name = "Płyn do szyb",
                Price = 4,
                Amount = 10,
            };
            c.Description();
            Nails n = new Nails
            {
                Name = "Gwoździe",
                Price = 6,
                Amount = 15,
                Length = 50,
                Thickness = 120,
                Type = "Brak łepka"
            };
            n.Description();
            Sandpaper s = new Sandpaper
            {
                Name = "Papier ścierny",
                Price = 3,
                Amount = 10,
                Granularity = "120",
                Width = "30"
            };
            s.Description();
            Furniture f = new Furniture
            {
                Name = "Fotel",
                Price = 300,
                Amount = 3,
                Collection = "Nowoczesna"
            };
            f.Description();
            Console.ReadKey();
        }
    }
}
