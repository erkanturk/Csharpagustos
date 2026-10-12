namespace _13_Methods_5_OverLoad
{
    /// <summary>
    /// Program.cs tüm yapıların çalıştığı alan
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Aşırı yüklemeli method
             * Normal durumda methodlar aynı isim  değerlerini taşıyamazlar
             * Fakat overload method yapısı ile aynı isimdeki method
             * Farklı imza tipi ile tanımlanabilir
             * Bu yapıya eş değer olarak sık kullandığımız bir method yapısı vardır.
             * Console.WriteLine() methodu kendisi dışında toplam 19 aşırı yüklemeye sahiptir
             * OOP temel ilkelerinden biri olan Polymorphism yapısını destekleyen static polymorphism(Çok biçimcilik)  yapısına
             * overload method yapısı denir
             * Birt methodun birden fazla tip ile bize cevap verebilmesini sağlar.
             */
            Console.WriteLine();

            Yaz("Merhaba Overload",10);
            Yaz();
            Yaz("Merhaba OverLoad");
            Yaz(10);
            Yaz(10, 10.5);
        }
        static void Yaz()
        {
            Console.WriteLine("Merhaba Dünya");
        }
        static void Yaz(string x)
        {
            Console.WriteLine(x);
        }
        
        static void Yaz(string y, int sayi)
        {
            Console.WriteLine(y, sayi);
        }

        /// <summary>
        /// int sayı alır
        ///  <see href="https://www.w3schools.com/"/>
        /// </summary>
        ///
        /// <param name="x"></param>
        static void Yaz(int x)
        {
            Console.WriteLine(x);
        }
        /// <summary>
        /// Bu method double 2 sayı alır ve aldığı sayıları toplar
        /// </summary>
        /// <param name="s"></param>
        /// <param name="s2"></param>
        static void Yaz(double s, double s2)
        {
            Console.WriteLine(s + s2);
        }
        static void Yaz(int x, int x2)
        {
            Console.WriteLine(x+"=="+x2);
        }
    }
}
