using System;
using System.Collections.Generic;
using System.Text;

namespace _24_Constructor_3_Readonly
{
    internal class ReadonlyTest
    {
        public readonly double Pi=3.14;

        //static void Yaz()//Hata verir Readonly yapısı sadece constructor tarafından güncellenir
        //{
        //    Pi = 4;
        //}
        public ReadonlyTest()
        {
            Pi = 4;
        }

    }
}
