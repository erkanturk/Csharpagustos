using System;
using System.Collections.Generic;
using System.Text;

namespace _28_PartialClass
{
    internal partial class Personel
    {
        public Personel(string test)
        {
            
        }
        public void Yazdir()
        {
            Console.WriteLine($"AdSoyad:{AdSoyad} Adres:{Adres} Email:{Email}");
        }
    }
}
