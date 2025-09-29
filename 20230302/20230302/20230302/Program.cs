using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//        I
//ez kell V
using System.IO;


namespace _20230302
{
    class Program
    {
        static void Main(string[] args)
        {

            //beolvasa();
            //fejvagyiras();
            szigetek();


            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
         
        }
        static void beolvasa()
        {
            //tömbe olvasás
            string[] beolvas = File.ReadAllLines("gyümölcsök.txt");
            foreach (var item in beolvas)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine("A gyümölcsök száma: ", +beolvas.Length);
            List<string> gyumolcs = new List<string>();
            foreach (var item in File.ReadAllLines("gyümölcsök.txt", Encoding.Default))
            {
                gyumolcs.Add(item);
            }
            foreach (var item in gyumolcs)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(gyumolcs.Count);

            string[] beolvas1 = File.ReadAllLines("párosok.txt");
            int[] parosok = new int[beolvas1.Length];
            for (int i = 0; i < parosok.Length; i++)
            {
                parosok[i]= (beolvas1);

            }
            foreach (var item in parosok)
            {
                Console.WriteLine(parosok);
            }

            Console.WriteLine("Ennyi páros szám van:", +parosok.Length);
            Console.WriteLine("Az összege: ", +parosok.Sum());
            Console.WriteLine("Az összege: ", +parosok.Min());
            Console.WriteLine("Az összege: ", +parosok.Max());
            Array.Sort(parosok);
            List<int> parosok1 = new List<int>();
            foreach (var item in File.ReadAllLines("párosok.txt"))
            {
                parosok1.Add(int.Parse(item));
            }
        }*/


         static void fejvagyiras()
        {
            string[] beolvas = File.ReadAllLines("fejvagyiras.txt");
            Console.WriteLine("Elemek száma: ", +beolvas.Count());
            
            

        }
       */
        static void szigetek()
        {
            string[] beolvas = File.ReadAllLines("sziget.txt");
            int[] szigetcsoport = new int[beolvas.Length];
            for (int i = 0; i < szigetcsoport.Length; i++)
            {
                szigetcsoport[i] = (beolvas);
            }
            foreach (var item in szigetcsoport)
            {
                Console.WriteLine(szigetcsoport);
            }
            Console.WriteLine("Ennyi az összege: " + szigetcsoport.Length);
            Console.WriteLine("Ennyi az összege: " + szigetcsoport.Sum());
            Array.Sort(szigetcsoport);

        }
    }
}
