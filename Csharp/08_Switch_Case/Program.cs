namespace _08_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Switch Case (Koşul yapısı)
             * Gelen değere göre içindeki sabit case yapılarını kontrol eder
             * Gelen koşula uyan bir case yapısı var ise case içinde bulunan kodlar çalışır
             * Hiç bir case koşula uygun değil ise default kısmı çalışır.
             * Her case bloğunda  kod bitiminde break ifadesi ile belirtmemiz gerekir 
             * farklı durumlarda break ifadesi kullanmayıp farklı bir case e yönlendirme yapabiliriz.
             */
            #region Ödev
            /*
           kullanıcıdan alınan cinsiyet bilgisine göre
        ==> ERKEK ise
           yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
          ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
          6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
            yaşı 56 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
          yaş 56'ın altında ise çalıştığı gün sayısına göre eğer 5000 ve üstü ise 
          maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5000 
          altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */
            #endregion
            #region Plaka bulma uygulaması
            //Console.WriteLine("Şehir gir plaka bul");
            //string sehir = Console.ReadLine().ToLower();
            //switch (sehir)
            //{
            //    case "istanbul": Console.WriteLine($"{sehir} plakası 34"); break;
            //    case "ankara": Console.WriteLine($"{sehir} plakası 06"); break;
            //    case "adana": Console.WriteLine($"{sehir} plakası 01"); break;
            //    case "bursa": Console.WriteLine($"{sehir} plakası 16"); break;
            //    case "hatay": Console.WriteLine($"{sehir} plakası 31"); break;
            //    case "amasya": Console.WriteLine($"{sehir} plakası 05"); break;
            //    case "tokat": Console.WriteLine($"{sehir} plakası 60"); break;
            //    case "izmir": Console.WriteLine($"{sehir} plakası 35"); break;
            //    case "düzce": Console.WriteLine($"{sehir} plakası 81"); break;
            //    default:
            //        Console.WriteLine("Sistem de yaşanan yoğunlıktan dolayı bilgiye ulaşılamadı lütfen sonra tekrar deneyin");
            //        break;
            //}

            #endregion
            #region Sözlük
            /*Kullanıcıdan türkçe bir kelime girmesini isteyeceğiz kullanıcının girdiği değerin ingilizce karşılığını göstereceğiz
             * Örneğin Merhaba Kelimesinin ingilizcesi Hello olarak gelecek
             */
            //Console.WriteLine("TR/EN sözlük\nKelimeniz:");
            //string kelime = Console.ReadLine().ToLower();
            //switch (kelime)
            //{
            //    case "mavi": Console.WriteLine($"{kelime} ingilizcesi blue"); break;
            //    case "sarı": Console.WriteLine($"{kelime} ingilizcesi yellow"); break;
            //    case "bulutlu": Console.WriteLine($"{kelime} ingilizcesi cloudy"); break;
            //    case "gökyüzü": Console.WriteLine($"{kelime} ingilizcesi sky"); break;
            //    case "araba": Console.WriteLine($"{kelime} ingilizcesi car"); break;
            //    case "elma": Console.WriteLine($"{kelime} ingilizcesi apple"); break;
            //    case "defter": Console.WriteLine($"{kelime} ingilizcesi notebook"); break;
            //    default:
            //        Console.WriteLine("Aradığınız kelime sözlükte bulunmamaktadır.");
            //        break;
            //}
            #endregion

            #region Market sistemi
            //Console.WriteLine("Yapmak istediğiniz işlemi belirtin\n1-Stok eksilt\n2-Ürün ekle\n3-Satış yap");
            //int secim = Convert.ToInt32(Console.ReadLine());
            //switch (secim)
            //{
            //    case 1: Console.WriteLine("Stok miktarı 1 adet azaltıldı");break;
            //    case 2: Console.WriteLine("İstenilen ürün başarıyla eklendi"); break;
            //    case 3: Console.WriteLine("Satış başarılı"); goto case 1;//goto case diyerek birden fazla case yapısını kullanabiliriz.

            //}

            #endregion
            #region Atm
            //bir atm programı yapalım 1 bakiye görüntüle 2 para yatır 3 para çek 4 çıkış olsun 
            // para yatırılma durumunda da para çekilme durumunda da bakiye görüntülendi yazısı gelsin.
            //double bakiye = 50000;
            //Console.WriteLine("Yapmak istediğiniz işlem\n1-Bakiye görüntüle\n2-Para yatır\n3-Para çek\n4-Çıkış Yap");
            //string secim = Console.ReadLine();
            //switch (secim)
            //{
            //    case "1":
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"Mevcut bakiyeniz:{bakiye}"); break;
            //    case "2":
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine($"Yatırmak istediğiniz tutar");
            //        double tutar = Convert.ToDouble(Console.ReadLine());

            //        bakiye += tutar;
            //        goto case "1";
            //    case "3":
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"Çekmek istediğiniz tutar");
            //        double eksiBakiye = Convert.ToDouble(Console.ReadLine());
            //        bakiye -= eksiBakiye;
            //        goto case "1";
            //    case "4": Console.WriteLine("Oturum Güvenli Bir Şekilde Sonlandırıldı. İyi Günler Dilerim"); break;

            //    default: Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Hatalı işlem"); goto case "4";
            //}



            //    double bakiye = 50000;
            //git:
            //    Console.WriteLine("Yapmak istediğiniz işlem\n1-Bakiye görüntüle\n2-Para yatır\n3-Para çek\n4-Çıkış Yap");
            //    string secim = Console.ReadLine();
            //    switch (secim)
            //    {
            //        case "1":
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"Mevcut bakiyeniz:{bakiye}"); break;
            //        case "2":
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine($"Yatırmak istediğiniz tutar");
            //            double tutar = Convert.ToDouble(Console.ReadLine());

            //            bakiye += tutar;
            //            goto case "1";
            //        case "3":
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine($"Çekmek istediğiniz tutar");
            //            double eksiBakiye = Convert.ToDouble(Console.ReadLine());
            //            if (bakiye >= eksiBakiye)
            //            {

            //                bakiye -= eksiBakiye;
            //                goto case "1";
            //            }
            //            else
            //            {

            //                Console.WriteLine("Yetersiz bakiye");
            //                goto git;
            //            }

            //        case "4": Console.WriteLine("Oturum Güvenli Bir Şekilde Sonlandırıldı. İyi Günler Dilerim"); break;

            //        default: Console.BackgroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Hatalı işlem"); goto case "4";
            //    }
            //Kullanıcıdan 2 adet sayı değeri alınacak ve yapmak istediği işlem sorulacak
            //+ - * / olarak işlem seçecek seçtiği işlem bir case yapısında aldığı sayıları işleme tabi tutacak.
            #endregion
            #region Hesap Makinesi
            Console.WriteLine("1.Sayı değeri");
            double sayi= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı değeri");
            double sayi2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi belirtiniz\n+\n-\n*\n /");
            char islem = Convert.ToChar(Console.ReadLine());
            switch (islem)
            {
                case '+': Console.WriteLine($"Toplama işlemi sonucu:{sayi+sayi2}"); break;
                case '*': Console.WriteLine($"Çarpma işlemi sonucu:{sayi*sayi2}"); break;
                case '-': Console.WriteLine($"Çıkarma işlemi sonucu:{sayi-sayi2}"); break;
                case '/':
                    if (sayi2 == 0)
                    {

                        Console.WriteLine("Sayı 0 a bölünemez");
                       
                    }
                    else
                    {

                        Console.WriteLine($"Bölme işlemi sonucu:{sayi / sayi2}");
                    }
                    break;
                default:
                    break;
            }
            #endregion
        }
    }
}
