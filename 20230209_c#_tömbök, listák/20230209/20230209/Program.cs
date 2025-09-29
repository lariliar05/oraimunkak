using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230209
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            feladat5();









            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.Write("Kérem a darabszámot");
            int szam = int.Parse(Console.ReadLine());
            //Tömb
            int[] szamok = new int[szam];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write($"Kérem az {i + 1} első számot.");
                szamok[i] = int.Parse(Console.ReadLine());
            }
            int  DB_prl = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 1)
                {
                    DB_prl++;
                }
              
            }
            Console.WriteLine(DB_prl);

            //tömb eljárása forarch ciklussal
            //akkor nem hasznljuk ha nincs index

            DB_prl = 0;
            foreach (var item in szamok)
            {
                if (item%2==1)
                {
                    DB_prl++;
                }
               
            }
            Console.WriteLine(DB_prl);
            //listával
            List<int> szamlista = new List<int>();
            for (int i = 0; i < szam; i++)
            {
                Console.Write($"Kérem az {i + 1} első számot.");
                szamlista.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Az elemek száma {szamlista.Count}");
            Console.WriteLine($"A lista kapacitása {szamlista.Capacity}");
            Console.WriteLine($"A legkisebb {szamlista.Min()}");
            Console.WriteLine($"A legnagyobb {szamlista.Max()}");
            Console.WriteLine($"Az összegük {szamlista.Sum()}");
            Console.WriteLine($"A legkisebb {szamlista.Average()}");
            DB_prl = 0;
                for (int i = 0; i < szamlista.Count; i++)
            {
                if szamlista(i)
                    {

                    }

            }
                
        }
        static void feladat2()
        {
            Console.WriteLine("Kérem a darabszámot!")
            int szam = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();
            int[] szamok1= new int[szam];
            int osszeg = 0;
            if (szam<10)
            { 
                for (int i = 0; i < szam; i++)
			{
                    Console.Write($"Kérem a/az {a+1} szamot:")
                    szamok1[i] = int.Parse(Console.ReadLine());

			}
                foreach (var item in szamok1)
                Console.Write();
	            {
                if(item%2==0)
                    {
                        osszeg += item;
                    }
    
	            }

            }
            else
	    {
             for (int i = 0; i < szam; i++)
			{
               szamok.Add(rnd.Next(1,100));
               Console.Write(szamok[i]+" ");
			}
	    }
            Console.Writeline($"A páros számok összege: {osszeg}");
        }
        static void feladat3()
        {
            Console.WriteLine("Kérem a darabszámot! ");
            int szam = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();
            for (int i = 0; i < szam; i++)
			{
                szamok.Add(rnd.Next(1,21));
                Console.Write(szamok[i]+ " ");
			}
            Console.WriteLine("Páros szám és sorszáma");
            for (int i = 0; i < szamok.Count; i++)
			{
                if (szamok[i]%2==0)
	        {
            Console.WriteLine($"{szamok[i]}/t{i+1}");
	        }

			}
        }
        static void feladat4()
        {
            Console.WriteLine("Kérem a darabszámot! ");
            int szam = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();
            for (int i = 0; i < szam; i++)
            {
                szamok.Add(rnd.Next(1, 21));
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine("Egész számok: ");
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i]%2==0)
            {
                    Console.WriteLine($"{szamok[i]} /t {i}");
            }

            }
        }
        static void feladat5()
        {
            Console.WriteLine("Kérek egy számot! ");
            int szam = int.Parse(Console.ReadLine());
            List<int> paros = new List<int>();
            List<int> paratlan = new List<int>();
            for (int i = 0; i < szam; i++)
            {
                if (paros[i] % 2 == 0)
                {
                    Console.WriteLine($"{paros[i]}, ez a szám páros {i}");
                }
                
            }
        }
    }
}
