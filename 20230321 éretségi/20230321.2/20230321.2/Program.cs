using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230321._2
{
    class Program
    {
        static void Main(string[] args)
        {
            beolvas();




            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();

        }
        static void beolvas()
        {
            string[] beolvas = File.ReadAllLines("enaplo.txt");
            
        }
    }
}
