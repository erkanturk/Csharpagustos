namespace _05_If_Else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pratik için https://www.w3schools.com/cs/index.php
            #region Scopsuz If Else Kullanımı
            //Console.WriteLine("1.sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if(sayi>sayi2)
            //    Console.WriteLine($"{sayi} büyüktür {sayi2} ");
            //else if(sayi2>sayi)
            //    Console.WriteLine($"{sayi2} büyüktür {sayi} ");
            //else
            //    Console.WriteLine("Sayılar birbirine eşitttir");
            #endregion
            #region Terenary if else
            //? if 
            //: else
            //string metin = "C#";
            //bool sonuc = metin == "c#" ? true : false;
            //string deger = metin == "C#" ? "Eşittir" : "Eşit Değildir";
            //Console.WriteLine(sonuc);
            //Console.WriteLine(deger);
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //string sonuc = sayi > 5 ? "Sayı 5 den büyüktür" : sayi == 5 ? "Sayı 5 e eşittir" : "Sayı 5 den küçüktür";
            //Console.WriteLine(sonuc);
            #endregion

            #region Haftanın hangi günü
            /* Kullanıcıdan haftanın gününü alacağız kullanıcıdan aldığımız değer 1 ise pazartesi 2 ise salı 
             * diye devam edecek pazar gününe kadar
             * Kullanıcı 1 veya 7 arasında değer girmezse uyarı vereceğiz 
             * 1 ila 7 arasında değer giriniz diye
             */

            //Console.WriteLine("Haftanın hangi günü");
            //int gun = Convert.ToInt32(Console.ReadLine());
            //if (gun < 0 || gun > 7)
            //{
            //    Console.WriteLine("1 ila 7 arasında bir değer giriniz");
            //}
            //else if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2)
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3)
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartes");
            //}
            //else
            //{
            //    Console.WriteLine("Pazar");
            //}
            #endregion

            #region İndirim Örneği
            //Kullanıcıdan iki türün fiyatı isteyeceğiz fiyatların toplamı 2500 tl yi geçerse ucuz olan ürüne %25 indirim yapacağız
            //eğer fiyatlar 2500 tl yi geçmezse indirim uygulanmayacak.
            //double f1, f2, toplam;//Multi variables
            //Console.WriteLine("1. Ürün fiyatı");
            //f1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Ürün fiyatı");
            //f2 = double.Parse(Console.ReadLine());

            //toplam = f1 + f2;
            //if (toplam > 2500)
            //{
            //    if (f1 > f2)
            //    {
            //        f2 = f2 * 0.75;
            //    }
            //    else
            //    {
            //        f1 = f1 * 0.75;
            //    }
            //}
            //Console.WriteLine($"İndirim Uygulanmış toplam tutar {f1 + f2} indirimsiz hali {toplam}");
            #endregion

            #region Ödev
            /* Kullanıcıdan aylık geliri istenecek eğer geliri 40000 tl nin üstünde ise gelirine %12 vergi kesintisi uygulanacak ve
             * vergi uygulanmış maaşı ekranda yazdırılacak
             * Eğer geliri 40000 tl ve altında ise %9 vergi uyfalanıp yeni geliri ekrana yazdırılacak.
             */
            Console.WriteLine("Maaşınız");
            double maas = Convert.ToDouble(Console.ReadLine());
            if (maas > 40000)
            {
                Console.WriteLine($"Vergi uygulanmış maaş {maas*0.88}");
            }
            else
            {
                Console.WriteLine($"Vergi uygulanmış maaş {maas * 0.91}");
            }
            #endregion
        }
    }
}
