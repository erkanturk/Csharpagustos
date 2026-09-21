namespace _05_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Karar yapısı (Conditions) If else , switch case
             * Karar yapılarından sadece bir tanesi çalışır. Bir yapıda birden fazla koşul olması durumunda 
             * Karar yapıları devreye girer koşul olarak hangisi true dönerse o blokta bulunan kodlar çalışır
             * Eğer hiçbir koşul uymazsa else yapısı devreye girer ve geriye kalan tüm koşullar için else kısmı uygulanır.
             * Bir if else bloğunda birden fazla else if yapısı olabilir  fakat bir if bir else bulunabilir.
             * If else yapısının içerisinde farklı if else yapıları da barındırabiliriz.
             * !!!!Daima bu yapılar true olduğu sürece çalışır else dışında 
             * Else yapısında koşul yoktur.
             */

            #region Örnek 1
            //Kullanıcı bir sayı girecek bu sayının sıfırdan büyük yada küçük olduğunu kontrol edeceğiz.

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    Console.WriteLine("Girilen sayı 0 dan büyüktür. Sayı " + sayi);
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Girilen sayı 0 dan küçüktür. Sayı " + sayi);
            //}
            //else if (sayi == 0)
            //{
            //    Console.WriteLine("Sayı 0 a eşittir");

            //}
            #endregion

            #region Örnek2
            // Kullanıcının girdiği sayı tek mi çift mi olduğunu bulun
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı tektir");
            //}
            #endregion
            #region Örnek 3
            //Kullanıcıdan 2 adet ürün fiyatı alalım aldığımız ürün fiyatlarından Küçük olan ürüne %30 indirim uygulayalım 
            //Console.WriteLine("1.Ürün fiyatı");
            //double f1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün fiyatı");
            //double f2 = Convert.ToDouble(Console.ReadLine());

            //if (f1 > f2)//Clean code 
            //{
            //    Console.WriteLine(f2 * 0.70);

            //}
            //else 
            //{
            //    Console.WriteLine(f1*0.70);
            //}
            //3 ürünlü senaryo
            //Console.WriteLine("1.Ürün fiyatı");
            //double f1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün fiyatı");
            //double f2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("3.Ürün fiyatı");
            //double f3 = Convert.ToDouble(Console.ReadLine());

            //if (f1 > f2 && f1 > f3)//Clean code 
            //{
            //    if (f2 > f3)
            //    {
            //        Console.WriteLine(f3 * 0.70);
            //    }
            //    else
            //    {
            //        Console.WriteLine(f2 * 0.70);
            //    }

            //}
            //else if (f2 > f1 && f2 > f3)
            //{

            //    if (f3 > f1)
            //    {
            //        Console.WriteLine(f1 * 0.70);
            //    }
            //    else
            //    {
            //        Console.WriteLine(f3 * 0.70);
            //    }
            //}
            //else
            //{
            //    if (f2 > f1)
            //    {
            //        Console.WriteLine(f1 * 0.70);
            //    }
            //    else
            //    {
            //        Console.WriteLine(f2 * 0.70);
            //    }
            //}

            #endregion
            #region Yanlış if else kullanımı
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            ////if (sayi > 0)
            ////{
            ////    Console.WriteLine("Sayı Pozitiftir");
            ////}
            ////if (sayi < 0)
            ////{
            ////    Console.WriteLine("Sayı negatiftir");
            ////}
            ////if (sayi == 0)
            ////{
            ////    Console.WriteLine("Sayı nötürdür.");
            ////}

            //if (sayi > 0)//Clean code
            //{
            //    Console.WriteLine("Pozitiftir");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Negatiftir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı nötürdür");
            //}

            #endregion

            #region Örnek 5
            /*Kullanıcıdan Kullanıcı Adı şifre değeri girmesini isteyelim 
             * Sistemde kayıtlı olan string kullaniciAdi="Admin" şifre ise "A123" olsun
             * Kullanıcının girdiği değerle bizim kullanıcı adı ve şifremiz uyuşuyorsa Sisteme giriş başarılı mesajı yazdıralım 
             * Eğer uyuşmuyorsa uyarı verelim
             */
            //string kullaniciAdi = "Admin";
            //string sifre = "A123";
            //Console.WriteLine("Kullanıcı Adınız:");
            //string kad = Console.ReadLine();
            //Console.WriteLine("Şifre");
            //string pass = Console.ReadLine();

            //if (sifre == pass && kullaniciAdi == kad)
            //{
            //    Console.WriteLine("Sisteme giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            //}

            #endregion

            #region Örnek 6
            //string kullanici = "erkan";
            //string password = "1453";

            //Console.Write("Kullanıcı Adınız:");//Aynı satırda değer girmemizi sağlar
            //string Ad = Console.ReadLine();
            //Console.WriteLine("Şifre:");
            //string pass = Console.ReadLine();
            //if ((Ad == kullanici || Ad == "Erkan" || Ad == "e" || Ad == "E") && password == pass)
            //{
            //    Console.WriteLine("Sisteme giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş");
            //    if (Ad != kullanici && Ad != "Erkan" && Ad != "e" && Ad != "E")
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalıdır.");
            //        if (pass != password)
            //        {
            //            Console.WriteLine("Şifre hatalıdır");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Şifre hatalıdır.");
            //    }
            //}
            #endregion

            #region Örnek 7
            //Kullanıcının girdiği sayı değeri  öncelikle 0 dan büyük olup olmadığını kontrol edelim
            //eğer 0 dan büyükse 100 den büyük mü küçük mü eşitm kontrol edelim 
            Console.WriteLine("Sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 0)
            {
                Console.WriteLine("Sayı 0 dan büyüktür");
                if (sayi > 100)
                {
                    Console.WriteLine("Sayı 100 den büyüktür");
                }
                else if (sayi < 100)
                {
                    Console.WriteLine("Sayı 100 den küçüktür");
                }
                else
                {
                    Console.WriteLine("Sayı 100 e eşittir.");
                }
            }
            else
            {
                Console.WriteLine("Sayı 0 veya sıfırdan küçüktür.");
            }
            #endregion
        }
    }
}
