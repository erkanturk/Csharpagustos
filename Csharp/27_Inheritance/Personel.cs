using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Inheritance
{
    internal class Personel
    {
        public string Tc { get; set;  }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public int Yas { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string SigortaNo { get; set; }

        public void PersonelBilgileri()
        {
            Console.WriteLine($"Tc:{Tc}");
            Console.WriteLine($"AdSoyad:{AdSoyad}");
            Console.WriteLine($"Adres:{Adres}");
            Console.WriteLine($"Yaş:{Yas}");
            Console.WriteLine($"İşe Giriş Tarihi:{IseGirisTarihi}");
            Console.WriteLine($"Sigorta No{SigortaNo}");
            
        }
    }
}
