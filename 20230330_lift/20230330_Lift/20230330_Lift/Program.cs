using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230330_Lift
{
    class liftezes
    {
        public int kartyaszam, kezdoszint, celszint;
        public DateTime datum = new DateTime();
        public liftezes(string egysor)
            {
            string[] darabok = egysor.Split(' ');
            datum = DateTime.Parse(darabok[0]);
            kartyaszam = int.Parse(darabok[1]);
            kezdoszint = int.Parse(darabok[2]);
            celszint = int.Parse(darabok[3]);


            }
          

    }
    class Program
    {
        static List<liftezes> liftezesek = new List<liftezes>();
        static int ksz, csz;
        static void Main(string[] args)
        {
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();


            Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine();
        }
        static void feladat2()
        {
            foreach (var item in File.ReadAllLines("lift.txt"))
            {
                liftezesek.Add(new liftezes(item));
            }



        }
        static void feladat3()
        {
            Console.WriteLine($"3. feladat: {liftezesek.Count()}");
           

        }
        static void feladat4()
        {
            Console.WriteLine($"4. feladat: {liftezesek[0].datum:yyyy.MM.dd} - {liftezesek.Last().datum:yyyy.MM.dd}");
        }
        static void feladat5()
        {
            int maxcelszint = liftezesek[0].celszint;
            foreach (var item in liftezesek)
            {
                if (item.celszint>maxcelszint)
                {
                    maxcelszint = item.celszint;
                }
            }
            Console.WriteLine($"5. feladat: {0}", maxcelszint);

            List<int> celszintek = new List<int>();
            foreach (var item in liftezesek)
            {
                celszintek.Add(item.celszint);
            }
            Console.WriteLine($"5. feladat : {celszintek.Max()}");
        }
        static void feladat6()
        {
            Console.WriteLine($"6. Feladat: ");
            try
            {
                Console.Write("ksz: ");
                ksz = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                ksz = 5;
                throw;
            }
            try
            {
                Console.Write("csz: ");
                ksz = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                csz = 5;
                throw;
            }
        }
        static void feladat7()
        {
            bool vanbenne = false;
            foreach (var item in liftezesek)
            {
                if (item.kartyaszam==ksz && item.celszint==csz)
                {
                    Console.WriteLine($" 7. feladat: vanbenne");
                    vanbenne = true;
                    break;
                     
                }
            }
            if (vanbenne==false)
            {
                Console.WriteLine($"7. feladat: nincs benne");
            }
        }
        static void feladat8()
        {
            int elso = liftezesek.First<>();



        }


    }  
}
