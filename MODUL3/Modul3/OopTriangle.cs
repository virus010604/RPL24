using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    internal class OopTriangle
    {
        public class Segitiga
        {
            public double Alas { get; set; }
            public double Tinggi { get; set; }
            public Segitiga(double alas, double tinggi)
            {
                Alas = alas;
                Tinggi = tinggi;
            }
            public double HitungLuas()
            {
                return 0.5 * Alas * Tinggi;
            }
            public double HitungKeliling()
            {
                return Alas + Tinggi + Math.Sqrt(Math.Pow(Alas, 2)
                + Math.Pow(Tinggi, 2));
            }
            public void TampilkanPolaSegitiga(int tinggi)
            {
                for (int i = 1; i <= tinggi; i++)
                {
                    for (int j = 1; j <= tinggi - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void StartProgram()
        {
            Console.WriteLine("Pilih menu:");
            Console.WriteLine("1. Pythagoras");
            Console.WriteLine("2. Keliling dan Luas Segitiga");
            Console.WriteLine("3. Bentuk Pola Segitiga Sama Sisi");
            Console.WriteLine("4. Bentuk Pola Segitiga Siku-Siku\n");
            Console.Write("Masukkan pilihan: ");
            int pilihan = int.Parse(Console.ReadLine());
            if (pilihan == 1)
            {
                Console.Write("Masukkan panjang alas: ");
                double alas = double.Parse(Console.ReadLine());
                Console.Write("Masukkan panjang tinggi: ");
                double tinggi = double.Parse(Console.ReadLine());
                Segitiga segitiga = new Segitiga(alas, tinggi);
                double hipotenusa = Math.Sqrt(Math.Pow(alas, 2) +
                Math.Pow(tinggi, 2));
                Console.WriteLine($"Panjang hipotenusa:{ hipotenusa: F2}");
            }
            else if (pilihan == 2)
            {
                Console.Write("Masukkan panjang alas: ");
                double alas = double.Parse(Console.ReadLine());
                Console.Write("Masukkan panjang tinggi: ");
                double tinggi = double.Parse(Console.ReadLine());
                Segitiga segitiga = new Segitiga(alas, tinggi);
                double luas = segitiga.HitungLuas();
                double keliling = segitiga.HitungKeliling();
                Console.WriteLine($"Luas segitiga: {luas:F2}");
                Console.WriteLine($"Keliling segitiga:{ keliling: F2}");
            }
            else if (pilihan == 3)
            {
                Console.Write("Masukkan tinggi segitiga: ");
                int tinggi = int.Parse(Console.ReadLine());
                Segitiga segitiga = new Segitiga(0, 0);
                segitiga.TampilkanPolaSegitiga(tinggi);
            }
            else if (pilihan == 4)
            {
                RightAngledTriangle.PrintRightAngledTriangle();
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }
        }
    }
}