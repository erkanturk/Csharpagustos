using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Inheritance_3
{
    internal class Suv:Araba
    {
        public bool Ceker { get; set;  }
        public new void ArabaBilgileri()
        {
            base.ArabaBilgileri();
            Console.WriteLine("Çeker:"+Ceker);

        }
    }
}
