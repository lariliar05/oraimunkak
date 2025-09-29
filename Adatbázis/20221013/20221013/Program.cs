using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221013
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        
        {
            //paros();
            //henger();
            kup();

            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
        }
        static void paros()
        {
            int elso = rnd.Next(1, 10);
            int masodik = rnd.Next(0, 10);
            int harmadik = rnd.Next(0, 10);
            int haromjegyu = 100 * elso + 10 * masodik + harmadik;
            if (haromjegyu % 2 == 0)
            {
                Console.WriteLine($"A generált szám {haromjegyu}, páros");
            }
            else 
            {
                Console.WriteLine($"A generált szám {haromjegyu}, páratlan!");
            }
        }
        static void henger() 
        {
            Console.WriteLine("Kérem a henger alapkörének átmérőjét! ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Kérem a henger magasságát! ");
            double m = double.Parse(Console.ReadLine());
            double r = d / 2;
            double felszin = 2 * r * Math.PI * (r + m);
            double terfogat = Math.Pow(r, 2) * Math.PI * m;
            Console.WriteLine($" A felszín:{Math.Round(felszin,2)}, és a terfogat: {terfogat:0.00}"); //sgrt 



        }
        static void kup()
        {
            Console.WriteLine("Kérem a kúp átmérőjét! ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Kérem a kúp magasságát! ");
            double m = double.Parse(Console.ReadLine());
            double r = d /2;
            double a = Math.Sqrt(Math.Pow(r, 2)+ Math.Pow(m,2));
            double A = r * Math.PI * (r + a);
            double V = Math.Pow(r, 2) * Math.PI * m;
            Console.WriteLine($"");






        }
    }
}
