namespace _13_Methods_3_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Geriye değer döndüren methodlar
             * Void keyword'ü kullanılamaz int ,double ,string char,decimal vb gibi veri tipleri alır
             * yada Sınıf yapısı koleksiyon yapısı dönderirler
             * Return ifadesi mutlaka olmalıdır.
             * return ifadesi bir işlemin sonucunu yada bir değeri dönderir
             * return ifadesi birden fazla değer dönderemez. eğer tuble method değilse
             */
            Yaz();
            double veri = Dondur();
            veri += 10;
            Console.WriteLine(veri);

            Yaz2("Naber");
            
            Console.WriteLine(Yazdir("Naber"));
        }
        static double Dondur()
        {
            return 123.45;
        }
        static void Yaz()
        {
            Console.WriteLine(123.45);
        }
        static void Yaz2(string metin)
        {
            Console.WriteLine(metin);
        }
        static string Yazdir(string metin)
        {
            Console.WriteLine(metin);
            metin = "iyi sen";
            return metin;
        }

    }
}
