using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230221
{
    class Program
    {
        static string[] nev = new string[14];
        static void Main(string[] args)
        {
            int n = nev.Length;
            for (int i = 0; i < nev.Length; i++)
            {
                Console.WriteLine("Kérek egy Vezették és Kersztnevet (Nevet) ");
                nev[i] = Console.ReadLine();

            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1 ; j  < n; j ++)
                {
                    int cmp = nev[i].CompareTo(nev[j]);
                    if (cmp < 0)
                    {
                        string csere = nev[j];
                        nev[j] = nev[i];
                        nev[i] = csere;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i}", nev[i]);
            }
            {
                Console.WriteLine("Várunk a következőre!");
            }



            
            
          
        }
    }
}
