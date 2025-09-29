using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_hasonlit
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg1, szoveg2;
            Console.WriteLine("Kérlek adj meg két nevet!\nabc sorrendben kiírom!");
            Console.WriteLine(); //átláthatóság miatti üres sor

            Console.Write("első név: "  ); 
            szoveg1 = Console.ReadLine();
            
            Console.Write("második név: ");
            szoveg2 = Console.ReadLine();

            Console.WriteLine(); //átláthatóság miatti üres sor

            /*ELMÉLET
            két string: str1 és str2 összehasonlítása:
              
               int cmp = "str1".CompareTo("str2");

               if (cmp == 0) { Console.WriteLine("str1 = str2"); }

               if (cmp > 0) { Console.WriteLine("str1 > str2"); }

               if (cmp < 0) { Console.WriteLine("str1 < str2"); }*/

            Console.WriteLine(); //átláthatóság miatti üres sor

            //a CompareTo metódus összhasonlítja a két stringet
            int cmp= szoveg1.CompareTo(szoveg2);
            
            //a cmp változó értékének kiíratása:
            Console.WriteLine("a \"cmp\" változó értéke:{0}", cmp);

            if (cmp > 0)
            {
                /* mivel a "cmp" változó értéke "+1"
                 * így a nevek sorrendje az abc szerint 
                 * nem növekvő. Így a kiíratásnál a 
                 * "szoveg2" változót kell kiírnunk előbb,
                 * majd a "szoveg1"-et*/
                Console.WriteLine("abc sorrendben: {0}, {1}", szoveg2, szoveg1);
            }
            else
            {
                if (cmp < 0)
                {
                    /*mivel a "cmp" változó értéke "-1"
                    * így a nevek sorrendje az abc szerint 
                    * növekvő. Így a kiíratásnál a 
                    * "szoveg1" változót írjuk ki előbb,
                    * majd a "szoveg2"-et*/
                    Console.WriteLine("abc sorrendben: {0}, {1}", szoveg1, szoveg2);
                }
                else
                {
                    /*mivel a "cmp" változó értéke "0"
                    * így a nevek megegyeznek, mindegy hogy 
                    * milyen sorrendet használunk*/
                    Console.WriteLine("abc sorrendben: {0}, {1}", szoveg1, szoveg2);

                }
            }
                                   
            
            Console.ReadLine();
        }
    }
}
