using System.Threading.Channels;

namespace _10_Donguler_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Loops(Döngüler) For,While,Do While,Foreach(Koleksiyon döngü yapısı)  
             * Bir işi tekrar tekrar aynı işlemleri yapmasına döngü denilir.
             * Program içerisinde döngüler bir değerin birden fazla kez çalışmasını sağlar
             * Döngü yapısı true olduğu sürecede çalışır ve false durumunda sonlanır.
             * 
             * Örnek
             * for(veritipi değişken adı = değer ;koşul;artış veya azalış)
             */
            #region Örnek 1
            //1 den 10 a kadar sayıları ekrana yazdırın.
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Örnek 2 Mantıksal operatör döngüsü
            //for (int i = 0; i <10&&i<5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 100; i >0; i++)
            //{
            //    Console.WriteLine(i);//Sonsuz döngü
            //}
            //for (int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);//Sonsuz döngü
            //}

            //for (; ; )//Sonsuz döngü
            //{
            //    Console.WriteLine("Sonsuz döngü");
            //}

            #endregion
            #region Örnek3
            //0 dan başlıyarak 2 nin katlarını ekrana yazdıran döngü % alma kullanılmasın 100 e kadar yazdırsın
            //for (int i = 0; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //A dan z Ye harfleri nasıl yazdırırız ?
            //for (char i = 'A'; i <='z' ; i++)
            //{
            //    Console.WriteLine(i+"=>"+(int)i);
            //}
            #endregion
            #region Örnek4
            //5=>1*2*3*4*5 =>120 
            //Kullanıcıdan alınan sayının faktoriyelini hesaplayan yapı
            //Console.WriteLine("Girdiğin sayının faktoriyelini bul");
            //long faktoriyel = Convert.ToInt64(Console.ReadLine());
            //long deger = 1;
            //for (long i = 1; i <= faktoriyel; i++)
            //{
            //    deger *= i;
            //}
            //Console.WriteLine(deger);

            #endregion
            #region Çarpım Tablosu
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)//Daima içdeki döngü ilk sonlanır 
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}\t"); // \t bir tab boşluk bırak
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Örnek 5
            //1 den 10 a kadar sayıları yazdıran döngü olsun
            //fakat 4 5 sayıları ekrana yazılmasın  döngü 8 e geldiğinde 8 i yazıp döngü sonlandı desin
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 4 || i == 5)
            //    {
            //        continue;//bu adımı gördüğünde aşağısındaki kodları okumaz döngü noktasına gider.
            //    }
            //    if (i == 8)
            //    {
            //        Console.WriteLine(i);
            //        Console.WriteLine("Döngü sonlanıyor");
            //        break;//döngü kırma işlemi 
            //    }
            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)//Daima içdeki döngü ilk sonlanır 
            //    {
            //        if (i == 4 || i == 5)
            //        {
            //            continue;//bu adım içde bulunan döngü için geçerlidir.
            //        }
            //        if (i == 8)
            //        {
            //            Console.WriteLine(i);
            //            Console.WriteLine("Döngü sonlanıyor");
            //            break;//bu adım içde bulunan döngü için geçerlidir.
            //        }

            //        Console.WriteLine($"{i}*{j}={i * j}\t"); // \t bir tab boşluk bırak
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            /*200 den başlıyarak 7 ye tam bölünen sayıları sadece ekrana yazdıran döngü yapısı.
             * 7 tam bölünen ve bölünmeyenlerin toplamları
            */
            //int sayi = 0;
            //int sayi2 = 0;
            //for (int i = 200; i > 0; i--)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        sayi += i;
            //    }
            //    else
            //    {
            //        sayi2 += i;
            //    }
            //}
            //Console.WriteLine("7 ye bölünenlerin toplamı: "+sayi);
            //Console.WriteLine("7 ye bölünmeyenlerin toplamı: "+sayi2);

            //int s = 0;
            //Console.WriteLine(s);
            //int s2;
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("askdjaslkdjakl");
            //int toplam;//null


            //int.TryParse("123abc", out toplam);
            //Console.WriteLine(toplam);

            int s = 10;
            int s2 = 20;
            int toplam;
            toplam = s + s2;

        }
    }
}
