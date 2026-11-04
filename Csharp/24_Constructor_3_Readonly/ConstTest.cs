using System;
using System.Collections.Generic;
using System.Text;

namespace _24_Constructor_3_Readonly
{
    internal class ConstTest
    {
        //Const Yapısına sadece tanımlandığı zaman değer atanabilir sonradan değer ataması yapılamaz.
        public const double Pi = 3.14;

        public ConstTest()
        {
            //Sınıf ayağa kalkarken dahi bu yapı değişmez hata verir
            //Pi = 4;
        }
    }
}
