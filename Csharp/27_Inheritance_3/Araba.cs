using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Inheritance_3
{
    internal class Araba
    {
        //public required int ArabaId { get; set; }//bu değerin mutlaka girilmesi gerekiyor boş kalamaz. 
        public  int ArabaId { get; set; }
        public string ArabaMarka { get; set; }
        public string ArabaModel { get; set; }
        public YakitTuru Yakit { get; set; }
        public string Vites { get; set; }

        public string Renk { get; set; }

        public void ArabaBilgileri()
        {
            Console.WriteLine($"Şasi No:{ArabaId}");
            Console.WriteLine($"Marka:{ArabaMarka}");
            Console.WriteLine($"Model:{ArabaModel}");
            Console.WriteLine($"Vites:{Vites}");
            Console.WriteLine($"Yakıt:{Yakit}");
            Console.WriteLine($"Renk{Renk}");

        }

    }
    enum YakitTuru { Benzin,Dizel,Elektirik,Hybrit,Lpg}
}
