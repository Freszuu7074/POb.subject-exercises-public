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
    abstract class Number
        {
            public abstract void Load();
            public abstract void WriteOut();
        }
        class NInt : Number
        {
            public int Value { get; set; }
            public override void Load()
            {
                Value = int.Parse(Console.ReadLine());  
            }
            public override void WriteOut()
            {
                Console.WriteLine(Value);
            }
        }
        class NDouble : Number
        {
            public double Value { get; set; }
            public override void Load()
            {
                Value = double.Parse(Console.ReadLine());
            }
            public override void WriteOut()
            {
                Console.WriteLine(Value);
            }
        }
        static void Main(string[] args)
        {
            NInt n1 = new NInt();
            NDouble n2 = new NDouble();

            n1.Load();
            n2.Load();

            n1.WriteOut();
            n2.WriteOut();

            Console.ReadKey();
        }
    }
}
