using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230502
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] parosok = new int[tomb.Length];
            int[] paratlanok = new int[tomb.Length];

            int parosokIndex = 0;
            int paratlanokIndex = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosok[parosokIndex++] = tomb[i];
                }
                else
                {
                    paratlanok[paratlanokIndex++] = tomb[i];
                }
            }

            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0} ", tomb[i]);
            }

            Console.WriteLine("\nA páros számok:");
            for (int i = 0; i < parosokIndex; i++)
            {
                Console.Write("{0} ", parosok[i]);
            }

            Console.WriteLine("\nA páratlan számok:");
            for (int i = 0; i < paratlanokIndex; i++)
            {
                Console.Write("{0} ", paratlanok[i]);
            }
        }
    }
}
