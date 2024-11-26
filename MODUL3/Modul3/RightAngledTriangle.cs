using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    internal class RightAngledTriangle
    {
        public static void PrintRightAngledTriangle()
        {
            Console.Write("Masukkan tinggi segitiga: ");
            int tinggi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segitiga siku-siku:");
            for (int i = 1; i <= tinggi; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
