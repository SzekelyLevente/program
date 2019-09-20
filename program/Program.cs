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
            try
            {
                Console.WriteLine("Adja meg hogy hány darab számot szeretne megadni:");
                int db = int.Parse(Console.ReadLine());
                int[] szamok = new int[db];
                for (int i = 0; i < db; i++)
                {
                    Console.WriteLine("Adja meg a(z) " + (i + 1) + ". számot: ");
                    szamok[i] = int.Parse(Console.ReadLine());
                }
                int max = szamok[0];
                for (int i = 1; i < szamok.Length; i++)
                {
                    if (szamok[i] > max)
                    {
                        max = szamok[i];
                    }
                }
                Console.WriteLine("A legnagyobb szám: " + max);
                int min = szamok[0];
                for (int i = 1; i < szamok.Length; i++)
                {
                    if (szamok[i] < min)
                    {
                        min = szamok[i];
                    }
                }
                Console.WriteLine("A legkissebb szám: " + min);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.Write("Hiba történt!");
                Console.ReadKey();
            }
        }
    }
}
