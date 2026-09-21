namespace _05_If_Else_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ödev
            /* Kullanıcıdan isim yaş çocuk sayısı istenecek 
             * Eğer kullanıcı 45 yaşının altında ise çocuk sayısına bakılacak
             * ve çocuk sayısı 3'ten az ise çocuk başına 2500 tl maaşına ekleme yapılacak
             * 45 in üzerinde ise çocuk başına para verilmeyecek 5000 tl ekleme yapılacak 
             * eğer çocuk sayısı 3 ten fazla ise çocuk başına 2000 tl maaşına ekleme yapılacak 
             * Örneğin çıktı: Erkan Türk Maaşınız 40000 olarak görünecek.
             */

            #region Örnek1
            /* Kullanıcıdan 3 adet sayı alalım ve sayıları Büyük ortancı ve en küçük olarak ekrana yazdıralım 
             * Örneğin 15 en büyük 
             *         13 ortancı
             *         10 en küçük
             */

            //Console.WriteLine("1.Sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayı");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //if (sayi > sayi2 && sayi > sayi3)
            //{

            //    if (sayi2 > sayi3)
            //    {
            //        Console.WriteLine(sayi + " > " + sayi2 + " > " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi + " > " + sayi3 + " > " + sayi2);
            //    }

            //}
            //else if (sayi2 > sayi3 && sayi2 > sayi)
            //{
            //    if (sayi > sayi3)
            //    {
            //        Console.WriteLine(sayi2 + " > " + sayi + " > " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi2 + " > " + sayi3 + " > " + sayi);
            //    }
            //}
            //else
            //{
            //    if (sayi2 > sayi)
            //    {
            //        Console.WriteLine(sayi3 + " > " + sayi2 + " > " + sayi);
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi3 + " > " + sayi + " > " + sayi2);
            //    }
            //}
            #endregion

            #region Goto
            /* Goto satıra konuşlanma yapısıdır bir döngü yapısı değildir 
             * Konuşlanan satıra belli noktalarda geri dönmemizi sağlar.
             * Fakat bu yapı döngü gibi kullanılmamalıdır.
             */
            //    Console.WriteLine("Çay demleme algoritması");
            //    Thread.Sleep(5000);//Sisteme delay yani bekleme süresi ekleyecek 5000 milisaniye 5 saniye olarak kullanılır.
            //mutfak:
            //    Console.WriteLine("Mutfağa git");
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Çay su var mı ? (E/H)");
            //    Thread.Sleep(2000);
            //    string cevap = Console.ReadLine().ToUpper();//ToUpper(); Girilen her karakteri büyüt
            //    if (cevap == "E")
            //    {
            //        Console.WriteLine("Çaydanlığa su koy");
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Ocağın altını yak");
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Çaydanlığı ocağa koy");

            //    demleme:
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Çay demlendi mi ? (E/H)");
            //        string demle = Console.ReadLine().ToLower();//ToLower(); Girilen her karakteri küçült

            //        if (demle == "e")
            //        {
            //            Thread.Sleep(2000);
            //            Console.WriteLine("Demliğe Su koy");
            //        }
            //        else if (demle == "h")
            //        {
            //            Console.WriteLine("Bekle");
            //            goto demleme;
            //        }

            //    }
            //    else if (cevap == "H")
            //    {
            //        Console.WriteLine("Bakkala git");

            //    bakkal:
            //        Thread.Sleep(2000);
            //        Console.WriteLine("Bakkal Açık mı ? (E/H)");
            //        string bakkal = Console.ReadLine().ToLower();
            //        if (bakkal == "e")
            //        {
            //            Console.WriteLine("eksikleri al");
            //            Thread.Sleep(2000);
            //            Console.WriteLine("Eve dön");
            //            Thread.Sleep(3000);
            //            goto mutfak;

            //        }
            //        else
            //        {
            //            Console.WriteLine("Başka bakkala git");
            //            goto bakkal;
            //        }
            //    }
            #endregion

            #region Örnek 3
            //300 den başlıyarak 7 ye tam bölünen sayıları ekrana yazdırın. 0 olduğunda yapı duracak.
            //    int sayi = 300;
            //    int top1 = 0;
            //    int top2 = 0;
            //don:
            //    if (sayi % 7 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //        top1 += sayi;
            //        sayi--;
            //        goto don;
            //    }
            //    else
            //    {
            //        top2 += sayi;
            //        sayi--;

            //        if (sayi != 0)
            //        {
            //            goto don;
            //        }
            //        else
            //        {
            //            Console.WriteLine("İşlem Tamamlandı");
            //        }
            //    }
            //    Console.WriteLine($"7 bölünen toplam:{top1} bölünmeyen toplam:{top2}");

            //300 den başlıyarak 7 ye tam bölünen sayıları ekrana yazdırın. 0 olduğunda yapı duracak. ve 7 ye bölünmeyen sayıların toplamı ayrı
            //bölünenlerin ayrı olarak yazdırılacak örneğin 7 ye bölünen toplam 6897 bölünemeyen toplam 8756

            #endregion
            #region örnek 4
            /* Kullanıcıdan bir sayı alacağız kullanıcıdan aldığımız ilk sayı eğer 0 sa tekrar sayı girmesini isteyeceğiz
             * Kullanıcının girdiği sayı 10 sa tekrar sayı girecek 20 girdi 30 olacak toplayarak devam edeceğiz 
             * Fakat kullanıcının girdiği ilk sayının 0 olması mutlaka kontrol edilecek 0 değilse toplama işlemi yapılacak
             * kullanıcı bu yapıyı durdumak için tekrar 0 a bastığında yapı sonlanacak girilen sayılar toplanacak.
             */

            int sayac = 0;
            int toplam = 0;

        git:
            Console.WriteLine($"{sayac + 1}.sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayac == 0 && sayi == 0)
            {
                Console.WriteLine("İlk sayı 0 girilemez");
                goto git;
            }
            if (sayi == 0)
            {
                Console.WriteLine("işlem tamamlandı");
            }
            else if (sayi > 0)
            {
                sayac++;
                toplam += sayi;
                goto git;
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Lütfen pozitif sayı giriniz");
                goto git;
            }
            Console.WriteLine("Toplam: "+toplam);



            #endregion
        }
    }
}
