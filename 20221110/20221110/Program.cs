using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221110
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
            //feladat6();
            //feladat7();
            feladat8();


        }
        static void feladat6()
        {
            for (int i = 15; i < 93; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void feladat7()
        {
            for (int i= 100; i < 401; i++)
                if (i % 4 == 0)
            { 
             Console.WriteLine(i);
            
                
            }
            
        }
        static void feladat8()
        {
            for (int i = 100 i> -100; i--)
                if(i % 9 == 0)
            {
                Console.WriteLine(i);
               
            }

        
        }
    }
}
