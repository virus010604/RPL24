using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namesace Modul3
{
    public class TriangleType
    {
        public static void CheckTriangleType()
        {
            Console.Write("Masukkan panjang sisi a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan panjang sisi b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan panjang sisi c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Segitiga sama sisi");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Segitiga sama kaki");
            }
            else
            {
                Console.WriteLine("Segitiga sembarang");
            }
            Console.ReadLine();
        }
    }
}
