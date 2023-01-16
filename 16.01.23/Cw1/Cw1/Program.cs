using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1
{
    class Sortowanie
    {
        private List<int> Lista;
        public List<int> sortuj()
        {
            return new List<int>();
        }
        public void wyswietl(List<int> Lista)
        {
            foreach (var item in Lista)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
    class Babelkowe : Sortowanie
    {
        public List<int> sortuj(List<int> Lista)
        {
            for (int i = 0; i < Lista.Count-1; i++)
            {
                for (int j = 0; j < Lista.Count-1; j++)
                {
                    if (Lista[j] > Lista[j+1])
                    {
                        int tmp = Lista[j];
                        Lista[j] = Lista[j + 1];
                        Lista[j + 1] = tmp;
                    }
                }
            }
            return Lista;
        }
    }
    class Debilne : Sortowanie
    {
        public List<int> sortuj(List<int> Lista)
        {
            Lista.Sort();
            return Lista;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> L = new List<int>() { 5, 7, 2, 1, 4, 3 };

            /*Babelkowe sort = new Babelkowe();
            sort.wyswietl(L);
            List<int> W = sort.sortuj(L);
            sort.wyswietl(W);*/

            Debilne d = new Debilne();
            d.wyswietl(L);
            d.sortuj(L);
            d.wyswietl(L);

            Console.ReadKey();
        }
    }
}
