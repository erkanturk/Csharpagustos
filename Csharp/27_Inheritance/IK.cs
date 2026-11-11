using System;
using System.Collections.Generic;
using System.Text;

namespace _27_Inheritance
{
    internal class IK:Personel
    {
        public int PersonelSayisi { get; set; }

        public new void PersonelBilgileri()//personel sınıfındaki personel bilgileri
                                           //methodu ile burada kullanılan aynı method yapısı
                                           //sistem buradaki ile onu ayırıştırması için new keywordü kullandık
        {
            base.PersonelBilgileri();//base anahtar kelimesi ile personel sınıfındaki personelbilgileri methodunu kullanırız.
            Console.WriteLine(PersonelSayisi);
        }
    }
}
