using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20221208
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //gyumi();
            //karakterek();
            sziget();







            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();

        }
        static void feladat1()
        {
            string[] beolvas = File.ReadAllLines("párosok.txt");
            Console.WriteLine("Az elemek száma {0}", beolvas.Length);
            Console.WriteLine($"A legnagyobb{beolvas.Max()} ");
            int[] parosok = new int[beolvas.Length];
            for (int i = 0; i < parosok.Length; i++)
            {
                parosok[i] = int.Parse(beolvas[i]);
                Console.Write($"{parosok[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"A legnagyobb{beolvas.Max()}");
            Console.WriteLine($"A számok összege{parosok.Sum()}");
            Console.WriteLine($"A számok átlag{parosok.Average()}");
            Array.Sort(parosok);
            foreach (var item in parosok)
            {
                Console.Write($"{item} ");
            }
            //másképp
            int[] paros = new int[10];
            FileStream fs = new FileStream("párosok.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            int cv = 0;
            while (!sr.EndOfStream)
            {
                paros[cv] = int.Parse(sr.ReadLine());
                cv++;
            }


            sr.Close();
            fs.Close();
            Console.WriteLine();

        }

        static void gyumi()
        {
            string[] gyumolcsok = File.ReadAllLines("gyümölcsök.txt", Encoding.Default);
            foreach (var item in gyumolcsok)
            {
                Console.WriteLine(item);
            }
        }

        static void karakterek()
        {
            string[] karakter = File.ReadAllLines("karakterek.txt", Encoding.Default);
            foreach (var item in karakter)
            {
                Console.WriteLine(item);
            }
            
        }

        static void sziget()
        {
            string[] island = File.ReadAllLines("sziget.txt", Encoding.Default);
            foreach (var item in sziget)
            {

            }
            
        }
        

    }
}
