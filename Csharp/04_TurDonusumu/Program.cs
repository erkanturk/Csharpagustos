namespace _04_TurDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan gelen her değer metinseldir bu değeri kullanıcıdan alırken türünü değiştirmemiz gerekir
             * Bu tür durumlarda convert işlemi yaparız.
             */
            #region Casting 
            //int sayi = 123;
            //double deger = sayi;//Bilinçsiz tür dönüşümü
            //Console.WriteLine(deger.GetType());//GetType verinin tipini gösterir.

            //double sayi = 123;
            //int sayi2 = (int)sayi;//Bilinçli tür dönüşümü
            //Console.WriteLine(sayi2);
            //double sayi3 = 123.567;
            //int sayi4 = (int)sayi;
            //Console.WriteLine(sayi4);

            //char harf = 'A';

            //Console.WriteLine(harf);
            //Console.WriteLine((int)harf);
            //Console.WriteLine((char)sayi4);


            #endregion
            #region Convert
            //string deger = "10";
            //int sayi = Convert.ToInt32(deger);
            //Console.WriteLine(Convert.ToInt32(deger));
            //Console.WriteLine(10 +sayi);
            //string metin = "on";
            //int sayi = Convert.ToInt32(metin);//metinsel değer sayıya dönüştürülemez.
            //Console.WriteLine(sayi);

            //Console.WriteLine("Double değer girin");
            //double sayi;//Kullanıcının girdiği değeri okumak için ReadLine() yapısını kullanırız.

            //sayi = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(sayi + 20);

            //Console.WriteLine("Ad");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyad");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Yaş");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Cinsiyet");
            //char cinsiyet = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Doğum Tarihi");
            //DateTime time = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("Bilgileri onaylıyor musun ? True False");
            //bool truee = Convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine($"Ad:{ad}");//String interpolation
            //Console.WriteLine("Soyad"+soyad);//string yazım biçimi
            //Console.WriteLine("Yaş:{0} Cinsiyet:{1} DoğumTarihi:{2}",yas,cinsiyet,time);//Index yazım biçimi
            // Console.WriteLine(truee);
            //int toplam = 0;
            //Console.WriteLine(toplam);
            //Console.WriteLine("1.Sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int sayi2= Convert.ToInt32(Console.ReadLine());
            //toplam = sayi + sayi2;
            //Console.WriteLine(toplam);
            #endregion
            #region Ödev
            //Kullanıcıdan iki ürün fiyatı girmesini isteyelim kullanıcının girdiği iki ürün fiyatını toplayalım
            //ve bu toplam değere %30 indirim uygulayalım

            Console.WriteLine("1.Ürün fiyatı");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün fiyatı");
            double fiyat2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"İki ürünün toplamı: {fiyat+fiyat2} indirimli tutar:{(fiyat+fiyat2)*0.70}");


            #endregion
        }
    }
}
