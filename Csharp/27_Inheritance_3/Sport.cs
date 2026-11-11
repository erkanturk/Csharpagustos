using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Inheritance_3
{
    internal class Sport:Araba
    {
        public bool Cabrio { get; set; }

        public new void ArabaBilgileri()
        {
            base.ArabaBilgileri();
            Console.WriteLine(Cabrio);
        }
    }
}
