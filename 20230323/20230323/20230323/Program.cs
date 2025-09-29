using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230323
{
    class szakasz
    {
        public string kiindulopont, vegpont, pecsetelo;
        public int emelkedes, lejtes;
        public double hossz;
        public szakasz(string egysor)
        {
            string[] darabok = egysor.Split(';');
            kiindulopont = darabok[0];
            vegpont = darabok[1];
            hossz = double.Parse(darabok[2]);
            emelkedes = int.Parse(darabok[3]);
            lejtes = int.Parse(darabok[4]);
            pecsetelo = darabok[5];


        }
    }
    class Program
    {
        static List<szakasz> szakaszok = new List<szakasz>();
        static int kezdomagassag;
        static void Main(string[] args)
        {
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            HianyosNev();
            feladat7();






            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
        }
        static void feladat2()
        {
            kezdomagassag = int.Parse(File.ReadAllLines("kektura.csv")[0]);
            foreach (var item in File.ReadAllLines("kektura.csv").Skip(1));
            {
                szakaszok.Add(new szakasz(item));
            }
           
            

              
        }
        static void feladat3()
        {
            Console.WriteLine($"3. feladat Szakaszok száma {szakaszok.Count()}");
        }
        static void feladat4()
        {
            double hossz = 0;
            foreach (var item in szakaszok)
            {
                hossz = hossz + item.hossz;
            }
            Console.WriteLine($"A túra teljes hossza {hossz} km");
        }
        static void feladat5()
        {
            string kezdete = szakaszok[0].kiindulopont;
            string vege = szakaszok[0].vegpont;
            double hossz = szakaszok[0].hossz;
            foreach (var item in szakaszok)
            {
                if (item.hossz<hossz)
                {
                    hossz = item.hossz;
                    kezdete = item.kiindulopont;
                    vege = item.vegpont;
                }
            }
            Console.WriteLine($"5 feladat: A legrövidebb: {hossz}");
            Console.WriteLine($"5 feladat: A legrövidebb: {kezdete}");
            Console.WriteLine($"5 feladat: A legrövidebb: {vege}");
        }
        static bool HianyosNev()
        {
            string pecsetelohely;
            if (ph.Contains("Pecsetelőhely")==true)
            {
                return
            }
            else
            {
                return
            }
            
        }
        static void feladat7()
        { 

        }

    }   
}
