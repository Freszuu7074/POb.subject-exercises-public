                        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    internal class Program
    {
        public abstract class MenuComponent
        {
            public string name { get; set; }
            public void add(MenuComponent mc) { }
            public abstract void display();
        }
        public class MenuComposit : MenuComponent
        {
            List<MenuComponent> lmc = new List<MenuComponent>();
            public MenuComposit(string name)
            {
                this.name = name;
            }
            public void addComponent(MenuComponent mc)
            {
                lmc.Add(mc);
            }
            public override void display()
            {
                Console.WriteLine(name);
                foreach (var item in lmc)
                {
                    item.display();
                }
            }
        }  
        class MenuItem :MenuComponent
        {
            public MenuItem(string name) 
            {
                this.name = name;
            }
            public override void display()
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            MenuComposit struktura = new MenuComposit("struktura");
            MenuComposit kreacja = new MenuComposit("kreacja");
            MenuComposit zachowanie = new MenuComposit("zachowanie");

            MenuItem fasada = new MenuItem("fasada");
            MenuItem kompozyt = new MenuItem("kompozyt");
            MenuItem dekorator = new MenuItem("dekorator");
            MenuItem singleton = new MenuItem("singleton");
            MenuItem fabryka = new MenuItem("fabryka");
            MenuItem strategia = new MenuItem("strategia");
            MenuItem obserwator = new MenuItem("obserwator");

            struktura.addComponent(fabryka);
            struktura.addComponent(kompozyt);
            struktura.addComponent(dekorator);

            kreacja.addComponent(singleton);
            kreacja.addComponent(fabryka);

            zachowanie.addComponent(strategia);
            zachowanie.addComponent(obserwator);

            MenuComposit menu1 = new MenuComposit("MENU1");
            menu1.addComponent(struktura);
            menu1.addComponent(kreacja);
            menu1.addComponent(zachowanie);

            menu1.display();
            Console.ReadKey();
        }
    }
}
