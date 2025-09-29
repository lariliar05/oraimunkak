using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230323
{
    class Csarnok
    {
        public string csapat, varos, csarnok;
        public int befogadokepesseg;
        //konstuktor
        public Csarnok(string egysor)
        {
            string[] darabok = egysor.Split(';');
            csapat = darabok[0].Trim();
            varos = darabok[1].Trim();
            csarnok = darabok[2].Trim();
            befogadokepesseg = int.Parse(darabok[3]);
        }

    }
    class Program
        
    {
        static Csarnok[] csarnokok;
        static List<Csarnok> Csarnokok2 = new List<Csarnok>();
        static int atlag;
        static void Main(string[] args)
        {

            beolvasas();
            feladat2();
            feladat34();
            feladat5();
            feladat6();
            feladat7();
            feladat8();






            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
        
        }
        static void beolvasas()
        {
            string[] beolvas = File.ReadAllLines("palyak.txt");
            csarnokok = new Csarnok[beolvas.Length];
            for (int i = 0; i < csarnokok.Length; i++)
            {
                csarnokok[i] = new Csarnok(beolvas[i]);
            }
            /*Console.WriteLine(csarnokok.Length);
            Console.WriteLine(csarnokok[3].csarnok);*/

            foreach (var item in File.ReadAllLines("palyak.txt"))
            {
                Csarnokok2.Add(new Csarnok(item));
            }
            /*Console.WriteLine(Csarnokok2.Count);
            Console.WriteLine(Csarnokok2[3].csarnok);
            Console.WriteLine(Csarnokok2[4].varos);*/
        }
        static void feladat2()
        {
            Console.WriteLine($"2. feladat {Csarnokok2.Count} kosárpálya volt 2016-ban Magyaroszágon");

        }
        static void feladat34()
        {
            int osszeg = 0;
            foreach (var item in csarnokok)
            {
                osszeg += item.befogadokepesseg;
            }
            atlag = osszeg / csarnokok.Length;
            Console.WriteLine($"3. feladat őssznézőszám: {osszeg} ");
            Console.WriteLine($"4. feladat Az átlag nézószám: {atlag} ");
        }
        static void feladat5()
        {
            int db = 0;
            foreach (var item in Csarnokok2)
            {
                if (item.varos=="Budapest")
                {
                    db++;
                }
            }
            Console.WriteLine($"5. feladat: Budapesten {db} kosár csapat volt 2016-ban. ");
        }
        static void feladat6()
        {
            int minertek = csarnokok[0].befogadokepesseg;
            string mincsarnok = csarnokok[0].csarnok;
            foreach (var item in csarnokok)
            {
                if (item.befogadokepesseg<minertek)
                {
                    minertek = item.befogadokepesseg;
                    mincsarnok = item.csarnok;
                }
            }
            Console.WriteLine($"6.feladat:  A legkisebb befogadóképességű csarnok: {mincsarnok}");
        }
        static void feladat7()
        {
            int minertek = csarnokok[0].befogadokepesseg;
            string mincsarnok = csarnokok[0].csarnok;
            foreach (var item in csarnokok)
            {
                if (item.befogadokepesseg > minertek)
                {
                    minertek = item.befogadokepesseg;
                    mincsarnok = item.csarnok;
                }
            }
            Console.WriteLine($"7.feladat: Itt nézhetik meg a legtöbben:  {mincsarnok}");
        }
        static void feladat8()
        {
            List<string> kiir = new List<string>();
            foreach (var item in Csarnokok2)
            {
                if (item.befogadokepesseg<atlag)
                {
                    kiir.Add(item.csarnok);
                }
            }
            File.WriteAllLines("kispalyak.txt", kiir);
        }
    }
    
}
