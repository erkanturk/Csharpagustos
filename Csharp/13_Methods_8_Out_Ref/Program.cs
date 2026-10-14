namespace _13_Methods_8_Out_Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ref
            /* Ref var olan bir değeri method içerisine gönderip bu değeri güncelleyip dışarı çıkarmak için kullanılan bir yöntemdir.
             * Ref ile referans gösterdiğimiz bir değer olmalıdır bu değeri güncelleyip dışarı çıkarmamıza olanak tanır.
             * Örneğin bir fabrika düşünün bu fabrikada plastik malzeme geldi referansımız plastik
             * Bu malzeme sonrasında fabrikada işlem görüp dışarıya oyuncak olarak çıktı satışa hazır hale geldi mağzaya sunuldu
             */
            #region Ref Örnekleri
            //int s = 1;
            //int s2 = 2;
            //int s3 = 3;
            //Console.WriteLine(s);//MEthoda girmeden önce
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //RefMethod(ref s, ref s2, s3);//Methoddan sonra
            //Console.WriteLine(s);//20 
            //Console.WriteLine(s2);//30
            //Console.WriteLine(s3);//3

            //string metin = "Overload", metin2 = "fonksiyon";
            //Console.WriteLine(metin);
            //Console.WriteLine(metin2);
            //RefMethod2(ref metin, ref metin2);
            //Console.WriteLine(metin + " " + metin2);
            //double sayi = 123.45;
            //double sayi2 = 1234.45;
            //Console.WriteLine(RefLi(ref sayi, ref sayi2));
            //int[] dizi = new int[5];

            //Array.Resize(ref dizi,dizi.Length+1);

            #endregion
            #endregion
            #region Out
            int s;
            int s2;

            OutLu(out s, out s2);
            Console.WriteLine(s);
            Console.WriteLine(s2);
            OutLu(out int s3, out int s4);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            //string sayi = "10";
            string metin;
            // int.TryParse(sayi, out int sayi2);
            OutLu2(out metin, out string metin2);
            Console.WriteLine(metin+" "+metin2);
            #endregion
        }
        #region Ref
        static void RefMethod(ref int sayi, ref int sayi2, int sayi3)
        {
            sayi = 20;
            sayi2 = 30;
            sayi3 = 40;
        }
        static void RefMethod2(ref string sayi, ref string sayi2)
        {
            sayi = "Merhaba Ref";
            sayi2 = "Methodları";

        }

        static string RefLi(ref double sayi, ref double s2)
        {
            sayi = sayi * 1.20;
            s2 = s2 * 1.10;

            return $"Kdv uygulanmış toplam değerler {sayi} {s2}";
        }
        #endregion
        #region Out
        static void OutLu(out int sayi, out int sayi2)
        {
            sayi = 100;
            sayi2 = 200;
        }
        static void OutLu2(out string sayi, out string sayi2)
        {
            sayi = "Merhaba";
            sayi2 = "Out Method";
        }

        #endregion
    }
}
