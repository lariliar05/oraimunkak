using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220905
{
    class Program
    {
        static void Main(string[] args)
        {
            //egysoros megjegyzés
            /*többsoros megjegyzés*/
            // {} blokkhatároló 
            Console.WriteLine("Szia");
            //() függvényhívó, lehet paramétere, ez van a zárójelben
            //mindent ;-vel zárunk

            Console.WriteLine("Nyomj le egy billenytűt!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();

            // ez a két sor legyen minden program végén. A program ne zárodjon be.
            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();

        }
    }
}
