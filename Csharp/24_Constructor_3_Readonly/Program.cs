namespace _24_Constructor_3_Readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Dışa bağımlılık tarafında güvenli bir şekilde veriyi taşımak için readonly yapısını kullanırız.
             */
            ConstTest test = new ConstTest();
            Console.WriteLine(ConstTest.Pi);//static olarak algılandı
            ReadonlyTest test1 = new ReadonlyTest();
            Console.WriteLine(test1.Pi);

            Test test2 = new Test(test1);
            test2.Yaz();
        }
    }
}
