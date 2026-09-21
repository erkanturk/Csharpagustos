namespace _06_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random 
             * Simülasyon oyun ve kura sistemi gibi yapılarda kullanılır
             * Ram bellek tarafından rasgele bir aralıkta sayı üretilir ve bu üretilen sayı üzerinden işlem yapmamızı sağlar.
             */
            //    Random random = new Random();//instance örneklem nesneleme
            //rnd:
            //    int sayi = random.Next(1, 51);//1 ila 50 arasında rasgele değer oluşturan bir yapı 

            //    if (sayi != 49)
            //    {
            //        Console.WriteLine(sayi);
            //        goto rnd;
            //    }
            //    Console.WriteLine("işlem tamam ");
            #region Random Örnek
            //    Random random = new Random();
            //    int sanliSayi = random.Next(1, 51);
            //    int hak = 3;
            //basla:
            //    Console.WriteLine("Lütfen Şanslı sayınızı giriniz");
            //    int kullaniciSayisi = Convert.ToInt32(Console.ReadLine());
            //    if (sanliSayi == kullaniciSayisi)
            //    {
            //        Console.WriteLine("Tebrikler doğru tahmin hocanızla milli piyango oynayın");
            //    }
            //    else if (hak != 0)
            //    {
            //        hak--;
            //        Console.WriteLine("Tekrar deneyin");
            //        if (hak == 0)
            //        {
            //            Console.WriteLine("Şanslı sayı:" + sanliSayi);
            //        }
            //        else
            //        {
            //            goto basla;
            //        }
            //    }

            #endregion

            #region
            //Random ile şu aralıklarda değer oluşturacağız 1 30 a kadar değerler olsun 30 dahil olsun 
            //Program çalıştığında if ile sayı kontrol edilecek ve
            //eğer üretilen sayı 10 dan küçük ise hava soğuk sıkı giyin
            //10 15 arası hava serin  15 20 arası hava ılık 20 30 arası hava sıcak uyarısı versin
            Random random = new Random();
            int sayi = random.Next(1, 31);
            if (sayi < 10)
            {
                Console.WriteLine("Hava soğuk sıkı giyin derece:" + sayi);
            }
            else if (sayi >= 10 && sayi < 15)
            {
                Console.WriteLine("hava serin ceket giyin derece:" + sayi);
            }
            else if (sayi >= 15 && sayi < 20)
            {
                Console.WriteLine("Hava ılık derece:" + sayi);
            }
            else if (sayi >= 20 && sayi <= 30)
            {
                Console.WriteLine("Hava sıcak derece:"+sayi);
            }
            #endregion

        }
    }
}
