using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Class_Object
{
    public class Ogretmen
    {
        internal int OgretmenNo { get; set; }
        public string OgretmenAd { get; set; } = "";
        internal protected string OgretmenSoyad { get; set; } = "";
        private int Tel { get; set; } = 0;

        protected string Brans { get; set; } = "";

        public void OgretmenBilgileri()
        {
            Console.WriteLine($"Öğretmen No:{OgretmenNo}");
            Console.WriteLine($"Öğretmen No:{OgretmenAd}");
            Console.WriteLine($"Öğretmen No:{OgretmenSoyad}");
            Console.WriteLine($"Öğretmen No:{Brans}");
            Console.WriteLine($"Tel:{Tel}");
        }
    }
}
