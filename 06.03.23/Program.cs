using System;
class Device
{
    public string Brand { get; set; }
    public string Model { get; set; }
}
class DesktopComputer : Device
{
    public string CaseType { get; set; }
}

class Laptop : Device
{
    public double ScreenSize { get; set; }
    public string Color { get; set; }
}

class Opiekun
{
    public string Name { get; set; }
    public string Email { get; set; }
}

class Client
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

class Repair
{
    public DesktopComputer DesktopComputer { get; set; }
    public Laptop Laptop { get; set; }
    public string ProblemDescription { get; set; }
    public string Date { get; set; }
    public Opiekun Opiekun { get; set; }
    public Client Client { get; set; }
}

class Serwisant
{
    public string Name { get; set; }

    public void Repair(DesktopComputer desktopComputer, string problemDescription)
    {
        Console.WriteLine("Naprawiam komputer stacjonarny {0} {1} z problemem: {2}", desktopComputer.Brand, desktopComputer.Model, problemDescription);
    }

    public void Repair(Laptop laptop, string problemDescription)
    {
        Console.WriteLine("Naprawiam laptopa {0} {1} z problemem: {2}", laptop.Brand, laptop.Model, problemDescription);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DesktopComputer desktopComputer = new DesktopComputer();

        desktopComputer.Brand = "x-kom";
        desktopComputer.Model = "G4M3R";
        desktopComputer.CaseType = "Slim";

        Laptop laptop = new Laptop();
        laptop.Brand = "Lenovo";
        laptop.Model = "ThinkPad";
        laptop.ScreenSize = 15.6;
        laptop.Color = "Czarny";

        Repair repairOrder = new Repair();
        repairOrder.DesktopComputer = desktopComputer;
        repairOrder.Laptop = laptop;
        Console.Write("Podaj problem komputera/laptopa: ");
        repairOrder.ProblemDescription = Console.ReadLine();
        repairOrder.Date = "06.03.23";

        Opiekun opiekun = new Opiekun();
        opiekun.Name = "Jan Kowalski";
        opiekun.Email = "jan.kowalski@example.com";

        Client client = new Client();
        client.Name = "Anna Nowak";
        client.Email = "anna.nowak@example.com";
        client.PhoneNumber = "123456789";

        Serwisant serwisant = new Serwisant();
        serwisant.Name = "Adam Nowak";
        serwisant.Repair(desktopComputer, repairOrder.ProblemDescription);

        Console.ReadKey();
    }
}