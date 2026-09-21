namespace _03_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazma prensibi
            /* Yazılda yazma prensipleri vardır.
             * CamelCase=adSoyad;
             * SnakeCase=ad_Soyad;
             * PascalCase=AdSoyad;
             * UpperCase=ADSOYAD;
             * lowerCase=adsoyad;
             * 
             * programlama yapılarında tanımlanan yapılar ingilizce karakterlere uygun olmalıdır.
             * ***Hatalı Yazımlar***
             * 1sayı,ad soyad,ad?soyad,?adsoyad, !adsoyad,ad-soyad; yazılım tarafında tek özel karakter _ dir.
             * programın içerisinde bulunan isimleri kullanmamak gerekir.
             * 
             * 
             * ***Doğru tanımlar***
             * sayi1,adSoyad,ad_soyad,adsoyad_,_adsoyad
             * 
             * Kullanmamamız gereken karakterler
             * (İ,ı,ş,ğ,ç,ü,ö,ç )vb karakterler kullanılmamalıdır.
             * fakat "bu alanda" istediğimiz gibi değerleri yazabiliriz. 
             * 
             */
            #endregion

            #region Aritmatik Operatörler
            /* + Toplama
             * - Çıkarma
             * * Çarpma
             * "/" Bölme
             * % mod alma bir sayının bölümünden kalan 10 / 3  kalan 1 dir.
             */
            #endregion
            #region Atama Operatörleri
            /* = Sağdaki değeri soldaki değişkene aktarır örneğin string ad="erkan";
             * += var olan miktarı artırmak için kullanırız örneğin 10+=25
             * -= var olan miktarı azaltma işlemi yapar.
             * *= var olan miktarla çarpma işlemi yapar
             *"/=" var olan miktara bölme işlemi yapar.
             * .Erişim operatörü Console.WriteLine();
             * ++ var olan sayıyı 1 artırma
             * -- var olan sayıyı 1 azaltma
             */

            //int sayi = 10;
            //sayi += 5;
            //Console.WriteLine(sayi);
            //sayi -= 5;
            //Console.WriteLine(sayi);
            //sayi *= 5;
            //Console.WriteLine(sayi);
            //sayi /= 5;
            //Console.WriteLine(sayi);

            //Console.WriteLine(sayi % 3);

            //sayi++;
            //Console.WriteLine(sayi);
            //sayi--;
            //Console.WriteLine(sayi);


            #endregion
            #region Karşılaştırma Operatörleri
            /* Karşılaştırma operatörleri sadece true veya false değer dönderir
             * > Büyüktür
             * < Küçüktür
             * >= Büyük veya eşittir
             * <= Küçük veya eşittir
             * == Eşittir
             * != Eşit değildir
             * ! Zıt operatörü
             */

            //int sayi = 10;
            //int sayi2 = 5;
            //Console.WriteLine(sayi>sayi2);//T
            //Console.WriteLine(sayi>=sayi2);//T
            //Console.WriteLine(sayi2>=5);//T
            //Console.WriteLine(sayi<=sayi2);//F
            //Console.WriteLine(sayi==sayi2);//F
            //Console.WriteLine(sayi!=sayi2);//T
            //bool deger = true;
            //Console.WriteLine(!deger);//false
            #endregion
            #region Mantıksal operatörle
            /* And(ve) && or(veya)|| 
             * Birden fazla koşul olması durumunda ve veya yapıları kullanılır
             * && matematikde çarpma işlemine benzer
             * Başlangıç    Bitiş   Sonuç
             *      1           0       0
             *      0           1       0
             *      0           0       0
             *      1           1       1
             *      && yapısı birden fazla koşul varsa bunların hepsinin true olması sonucunda true olarak çalışır.
             *      || matematikde toplamaya benzer
             *      1           0       1
             *      0           1       1
             *      0           0       0
             *      1           1       1
             *      
             */
            //int sayi = 10;
            //int sayi2 = 5;
            //Console.WriteLine(sayi > sayi2 && sayi >= 10);//T
            //Console.WriteLine(sayi >= sayi2 && sayi < 10);//f
            //Console.WriteLine(sayi2 >= 5 || sayi2 < 3);//T


            #endregion

            #region Kısayol Tuşları
            /*
             * cw+tab Console.WriteLine();
             * Ctrl+K+C seçilen satırları yorum satırına çevirir
             * Ctrl+K+U seçilen satırı yorum satırından çıkarır
             * Ctrl+D İmlecin olduğu yeri bir alt satıra kopyalar
             * Ctrl+Z geri alma
             * Ctrl+Y ileri alma
             * alt+shift+yön tuşları
             * Ctrl+A tüm sayfayı seç
             * Ctrl+K+D Düzenle
             * Ctrl+L imlecin olduğu satırı sil
             * Ctrl+B build al
             * Ctrl+F Seach 
             * Ctrl+H düzeltme 
             * Ctrl+G Satırı getirir.
             */
            #endregion

        }
    }
}
