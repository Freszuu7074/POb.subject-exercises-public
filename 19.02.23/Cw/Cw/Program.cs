using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw
{
    internal class Program
    {
        class student1
        {
            //pole - field
            public string name;
        }

        class student2
        {
            //pole - field
            private string name;
            //set - get
            public void setName(string name)
            {
                this.name = name;
            }
            public string getname()
            {
                return this.name;
            }
        }
        class student3
        {
            //pole - field
            private string name;
            //wlaciwosci - property
            public string studentName
            {
                get { return this.name;}
                set { this.name = value; }
            }
        }
        
        class student4
        {
            //wlasciwosci - property (bez pola?) glowny zysk c#
            public string studentName { get; set; }
        }

        class Animal
        {
            public string Name { get; set; }
            public bool Domestic { get; set; }
            public string Introduce()
            {
                return this.Name;
            }
        }

        class Dog : Animal
        {

        }

        class Wolf : Animal
        {

        }

        class Firma
        {
            public string narodowosc_firmy { get; set; }
            public virtual string nip { get; set; }
            
            public virtual string wystaw_fakture()
            {
                return nip;
            }
        }

        class Polska : Firma
        {
            public override string nip
            {
                get
                {
                    return "PL" + base.nip;
                }
                set
                {

                }
            }
        }

        class Niemcy : Firma
        {
            public override string nip
            {
                get
                {
                    return "DE" + base.nip;
                }
                set
                {

                }
            }
        }
        static void Main(string[] args)
        {
            student1 std1 = new student1();
            std1.name = "bart";
            Console.WriteLine(std1.name);

            student2 std2 = new student2();
            std2.setName("Pablo");
            Console.WriteLine(std2.getname());

            student3 std3 = new student3();
            std3.studentName = "Peter";
            Console.WriteLine(std3.studentName);

            student4 std4 = new student4();
            std4.studentName = "Paola";
            Console.WriteLine(std4.studentName);

            Dog dog = new Dog();
            dog.Name = "Burek";
            dog.Domestic = true;

            Wolf wolf = new Wolf();
            wolf.Name = "Basior";
            wolf.Domestic = false;

            Console.WriteLine(dog.Introduce()+" "+wolf.Introduce());

            //Base: Firma (pola: narodowość_firmy i nip) (PL_numer; DE_numer) PL778-123-12-12 DE567-345-56-67
            //metoda wystaw fakturę (z nipu NIP na kwotę x)
            //Derived: Polska, Niemiecka

            Console.ReadKey();
        }
    }
}
