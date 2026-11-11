using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Inheritance
{
    internal class Pazarlama:Personel
    {
        public int MusteriSayisi { get; set; }

        public  void PersonelBilgileri()
        {
            base.PersonelBilgileri();
            Console.WriteLine($"Müşteri Sayısı {MusteriSayisi}");
        }
    }
}
