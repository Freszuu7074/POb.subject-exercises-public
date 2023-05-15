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
        public interface ICar
        {
            string Mark { get; set; }
            void Drive();
        }
        public interface IAnimal
        {
            string HairColor { get; set; }
            void Run();
        }
        public class Car : ICar
        {
            public string Mark { get; set; }
            public void Drive()
            {
                Console.WriteLine("Samochód jedzie...");
            }
        }
        public class Bicycle : ICar
        {
            public string Mark { get; set; }
            public void Drive()
            {
                Console.WriteLine("Rower jedzie...");
            }
        }
        public class Dog : IAnimal
        {
            public string HairColor { get; set; }
            public void Run()
            {
                Console.WriteLine("Pies biegnie...");
            }
        }
        public class Cat : IAnimal
        {
            public string HairColor { get; set; }
            public void Run()
            {
                Console.WriteLine("Kot biegnie...");
            }
        }
        public class Motorcycle : ICar
        {
            public string Mark { get; set; }
            public void Drive()
            {
                Console.WriteLine("Motocykl jedzie...");
            }
            public void Sound()
            {
                Console.WriteLine("Motocykl wydaje dźwięk...");
            }
        }
        public class Horse2 : IAnimal
        {
            public string HairColor { get; set; }
            public void Run()
            {
                Console.WriteLine("Kot biegnie...");
            }
        }
        public abstract class Animal
        {
            public string Name { get; set; }
            public abstract void Sound();
        }
        public class Mammal : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Ssak wydaje dźwięk...");
            }
        }
        public class Bird : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Ptak wydaje dźwięk...");
            }
        }
        public class Reptile : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Gad wydaje dźwięk...");
            }
        }
        public class Lion : Mammal
        {
            public Lion()
            {
                Name = "Lion";
            }
        }
        public class Horse : Mammal
        {
            public Horse()
            {
                Name = "Horse";
            }
        }
        public class Eagle : Mammal
        {
            public Eagle()
            {
                Name = "Eagle";
            }
        }
        public class Penguin : Mammal
        {
            public Penguin()
            {
                Name = "Penguin";
            }
        }
        public class Crocodile : Mammal
        {
            public Crocodile()
            {
                Name = "Crocodile";
            }
        }
        public class Turtle : Mammal
        {
            public Turtle()
            {
                Name = "Turtle";
            }
        }
        static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>();
            cars.Add(new Car());
            cars.Add(new Bicycle());
            cars.Add(new Motorcycle());
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Horse2());

            Mammal Lion = new Mammal();
            Lion.Name = "Simba";
            Lion.Sound();

            Bird Eagle = new Bird();
            Eagle.Name = "Orzeł biały";
            Eagle.Sound();

            Reptile Crocodile = new Reptile();
            Crocodile.Name = "Olaf";
            Crocodile.Sound();

            Car car = new Car();
            car.Drive();

            Bicycle bicycle = new Bicycle();
            bicycle.Drive();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Drive();
            motorcycle.Sound();

            Dog dog = new Dog();
            dog.Run();

            Cat cat = new Cat();
            cat.Run();

            Horse horse = new Horse();
            horse.Name = "Olaf";
            horse.Sound();

            Console.ReadKey();
        }
    }
}
