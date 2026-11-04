using System;
using System.Collections.Generic;
using System.Text;

namespace _24_Constructor_3_Readonly
{
    internal class Test
    {
        public readonly ReadonlyTest test;
        public Test(ReadonlyTest test)
        {
            this.test = test;//DI Dependency Injection Dışa bağımlılık.
        }
        public void Yaz()
        {
            var deger = test;
            //test = 4;
            Console.WriteLine(deger);
        }
    }
}
