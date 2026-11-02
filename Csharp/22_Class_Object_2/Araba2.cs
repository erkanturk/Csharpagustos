using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Class_Object_2
{
    internal static class Araba2
    {
        //Static sınıflar static öğeler barındırır ve nesnesi oluşturulamaz.
        public static int Id { get; set; } = 1;
        public static string Marka { get; set; }
        public static string Model { get; set; }
        public static double Fiyat { get; set; }

        public static void Kaydet2()
        {
            
            Console.WriteLine("Marka:");
            Marka = Console.ReadLine();
            Console.WriteLine("Model:");
            Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Marka:{Marka} Model:{Model} Fiyat:{Fiyat}");
        }
    }
}
