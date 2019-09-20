using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Adja meg a(z) " + (i + 1) + ". számot: ");
                szamok[i] = int.Parse(Console.ReadLine());
            }
            int max = szamok[0];
            for (int i = 1; i < szamok.Length; i++)
            {
                if(szamok[i]>max)
                {
                    max = szamok[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: " + max);
            Console.ReadKey();
        }
    }
}
