using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Inheritance
{
    internal class Muhasebe:Personel
    {
        public string HesapSayisi { get; set; }

        public void PersonelBilgileri()
        {
            base.PersonelBilgileri();
        }
    }
}
