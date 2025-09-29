using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20221020_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            





            // Switch - case szerekzet
            //többírányú, elágazás, egy változó értéktöl függ
            //pl. egy osztályzat
            //bekérjük az osztályzatot

            Console.Write("Kérem az osztáylzatot! ");
            int osztalyzat = int.Parse(Console.ReadLine());
            switch (osztalyzat) // zárójelben a változó neve kerül

            {
                case 1:
                    Console.WriteLine("Elégtelen");
                    break; //break-el zárjuk
                case 2:
                    Console.WriteLine("Elégséges");
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    break;
                case 4:
                    Console.WriteLine("Jó");
                    break;
                case 5:
                    Console.WriteLine("Jeles");
                    break;


                default:
                    Console.WriteLine("Rossz értéket adtál meg! ");
                    break;



            }


            //Ugyanez fordivta

            Console.WriteLine("Kérek egy osztályzatot (jeles, jó...");
            string erdemjegy = Console.ReadLine();

            switch(erdemjegy.ToLower())
            {
                case "elégtelen":
                    Console.WriteLine(1);
                    break;
                case "elégséges":
                    Console.WriteLine(2);
                    break;
                case "Közepes":
                    Console.WriteLine(3);
                    break;
                case "Jó":
                    Console.WriteLine(4);
                    break;
                case "Jeles":
                    Console.WriteLine(5);
                    break;
                default:
                    Console.WriteLine("Helytelen érték");
                    break;




            }


            //Kérd be a hét napját, és írd ki hányadik a héten és forditva



            Console.WriteLine("Kérek egy számot a napot a hétből! ");
            int HET = int.Parse(Console.ReadLine());

            switch (HET)
            {
                case 1:
                    Console.WriteLine("Hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap");
                    break;
                default:
                    Console.WriteLine("Helytelen érték!");
                    break;




            }


            Console.WriteLine(" Kérek egy napot a hétből.");
            string het = Console.ReadLine();
            switch (het)
            {
                case "Hétfő":
                    Console.WriteLine(1);
                    break;
                case "Kedd":
                    Console.WriteLine(2);
                    break;
                case "Szerda":
                    Console.WriteLine(3);
                    break;
                case "Csütörtök":
                    Console.WriteLine(4);
                    break;
                case "Péntek":
                    Console.WriteLine(5);
                    break;
                case "Szombat":
                    Console.WriteLine(6);
                    break;
                case "Vasárnap":
                    Console.WriteLine(7);
                    break;
                default:
                    Console.WriteLine("Helytelen érték");
                    break;

            }




           Console.WriteLine("Nyomd le az Entert!");
            Console.ReadLine(); 
        }

    }
}
