using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Week_13_Statistik_Huruf_Kata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Kalimat  \t : ");
            string kalimat = Console.ReadLine();
            while (kalimat.Length < 3)
            {
                Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");
                Console.Write("Input Kalimat : ");
                kalimat = Console.ReadLine(); 
            }
            Console.Write("Input Kata \t : ");
            var kata = Console.ReadLine();
            while (kata.Length < 2)
            {
                Console.WriteLine("HURUF PADA KALIMAT KURANG PANJANG");
                Console.Write("Input Kata : ");
                kata = Console.ReadLine();
            }
            Console.WriteLine("Statistik Huruf : ");
            while (kalimat.Length > 0)
            {
                if (kalimat[0] != ' ')
                {
                    Console.Write($"{kalimat[0]} = ");
                }
                int counter = 0;
                for (int i = 0; i < kalimat.Length; i++)
                {
                    if (kalimat[0] == kalimat[i])
                    {
                        counter++;
                    }
                }
                if (kalimat [0] != ' ')
                {
                    Console.WriteLine(counter);
                    kalimat = kalimat.Replace(kalimat[0].ToString(), string.Empty);
                }
            }
            

            
        }
    }
}
