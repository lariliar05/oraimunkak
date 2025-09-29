using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20221214
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            feladat3();











            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();

        }

        static void feladat1()

        {
        string egysor = File.ReadAllText("első_szöveget tartalmaz.txt",Encoding.Default);
            Console.WriteLine(egysor);
            string[] darabok = egysor.Split(' ');
            Console.WriteLine("szavak:");
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Kiírás másképp");
               
            {

            }
        




        }

        static void feladat2()
        {
            string egysor = File.ReadAllText("számok2.txt");
            string[] darabok = egysor.Split(';');
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Az elemek {0}", darabok.Length);
            int[] szamok = new int[darabok.Length];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i]=int.Parse(darabok[i]);
            }
            Console.WriteLine($"A számok összege {szamok.Sum()}");
        }

        static void feladat3()
        {
            string egysor = File.ReadAllText("hosszú5_a_mentén.txt", Encoding.Default);
            Console.WriteLine(egysor);
            string[] darabok = egysor.Split('a');
            Console.WriteLine("Betű:");
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
