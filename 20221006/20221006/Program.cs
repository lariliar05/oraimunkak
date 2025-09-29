using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221006
{
    class Program
    {
        static void Main(string[] args)
        {
            paros();

           
            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
        }
        static void paros()
        {

            Console.Write("Kérek egy egész számot");
            int szam = int.Parse(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.Write("Megadott szám páros!");
            }



            else
            {
                Console.WriteLine("A megadott szám páratlan");
            }
        }
    }
}