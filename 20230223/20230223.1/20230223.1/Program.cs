using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230223._1
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat4();




            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
        }
        static void feladat4()
        {
            Console.WriteLine("Kérek egy számot! ");
            int szam = int.Parse(Console.ReadLine());
  
            List<int> paros = new List<int>();
            List<int> paratlan = new List<int>();
            for (int i = 0; i < szam; i++)
            {
                if (paros[i] % 2 == 0)
                {
                    Console.WriteLine($"{paros[i]}, ez a szám páros {i}");
                }

            }

        }
    }
}
