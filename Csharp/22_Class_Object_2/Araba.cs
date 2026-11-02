using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Class_Object_2
{
    internal class Araba//Nonstatic yapılar.
    {
        public int Id { get; set; } = 1;
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

        public void Kaydet(string Marka, string Model, double Fiyat)
        {
            this.Marka = Marka;//this o anki sınıfı temsil eder.
            this.Model = Model;
            this.Fiyat = Fiyat;
        }

        public void Kaydet1(List<Araba> arabalar)
        {
            Console.WriteLine("Marka:");
            Marka = Console.ReadLine();
            Console.WriteLine("Model:");
            Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat = Convert.ToDouble(Console.ReadLine());
            arabalar.Add(this);

        }
        public void Kaydet2()
        {
            Araba araba = new Araba();
            Console.WriteLine("Marka:");
            araba.Marka = Console.ReadLine();
            Console.WriteLine("Model:");
            araba.Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            araba.Fiyat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Marka:{araba.Marka} Model:{araba.Model} Fiyat:{araba.Fiyat}");
        }
    }
}
