namespace _23_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            /* Enum 
             * Enumlar sabitler olarak adlandırılan Sabit Sayısal Küme yapısıdır.
             * Bir veri yapısının hem metinsel hem sayısal karşılığı bulunur
             * Örneğin İstanbul dediğimizde metinseldir 34 ise sayısaldır ama bu plakanın
             * İstanbula ait olduğunu biliriz . Enumlar bu mantıkla çalışır.
             * Enum yapıları da metinsel veri değerler veri tabanında saklanırken sayısal olarak değer tutmamızı sağlar.
             * Kullanıcı metinsel olarak istanbulu görürken veri tabanından 34 değeri gelir 
             * Enum yapıları varsayılan olarak  0 dan başlar ve 1 er artarak devam eder.
             * Aynı değeri birden fazla kullanamayız 0 ,1,2,3,4,5 gibi değerler alabiliriz. 
             * aynı 0 değerini 2 farklı enum üyesine atayamayız.
             * Değerler benzersiz olmalıdır int long byte gibi tam sayı tipleri ile çalışır
             * Ondalıklı sayıları kullanamayız. Enum yapıları int tipinde çalışır ve 4 byte yer kaplar.
             * Varsayılan olarak int tipini alır.
             */
            #endregion
            #region Enum Kullanımı
            //Otomobil otomobil = new Otomobil();
            //otomobil.Marka = Markalar.Bmw;
            //otomobil.Model = "520d";
            //otomobil.Renk = "Siyah";
            //otomobil.UretimYili = 2020;
            //otomobil.YakitTipi = "Dizel";
            //otomobil.Vites = Vitesler.Otomatik;
            //otomobil.OzellikleriYazdir();

            //Console.WriteLine(Markalar.Bmw);
            //Console.WriteLine((int)Markalar.Bmw);
            //string[] markalar = Enum.GetNames(typeof(Markalar));
            ////Enum.GetNames() metodu enum yapısındaki tüm metinsel değerleri string[] tipinde döndürür.
            //Console.WriteLine("**********");
            //foreach (string item in markalar)
            //{
            //    Console.WriteLine(item);
            //}
            //byte[] markalar2 = (byte[])Enum.GetValues(typeof(Markalar));
            ////Enum.GetValues() metodu enum yapısındaki tüm sayısal değerleri byte[] tipinde döndürür.
            //foreach (byte item in markalar2)
            //{
            //    Console.WriteLine(item);
            //}

            //bool sonuc = Enum.IsDefined(typeof(Markalar), (byte)1);
            //bool sonuc2 = Enum.IsDefined(typeof(Markalar), "Fiat");
            //bool sonuc3 = Enum.IsDefined(typeof(Vitesler), 4);

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);


            //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("***************");
            //Thread.Sleep(2000);
            //Console.BackgroundColor =(ConsoleColor)3;

            //int sayi = 15;
            //for (int i = 0; i <=sayi; i++)
            //{
            //    string backColor = i.ToString();
            //    string foreColor = i.ToString();
            //    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            //    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            //    Console.Clear();
            //    Thread.Sleep(100);
            //    if (i == 15)
            //    {
            //        i = 0;
            //        continue;
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //while (true)
            //{
            //    Console.WriteLine("0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 " +
            //        "1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0" +
            //        " 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1" +
            //        " 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0" +
            //        " 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 " +
            //        "0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0" +
            //        " 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 " +
            //        "0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0" +
            //        " 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 ");
            //}
            #endregion
            //Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            /* KitapKategori adında bir enum yapısı oluşturun ve içerisine 5 farklı kategori ekleyin.
             * Aksiyon, Komedi, Dram, Korku, Romantik
             * Kullanıcı string olarak kategori girmesini isteyin
             * Kullanıcıdan aldığımız değer ile Switch Case yapısı ile hangi kategoriye ait olduğunu yazdırın.
             * Sayısal olarakda metinsel olarakda kullanıcı değeri girebilir  
             * 0 Veya Aksiyon, 1 veya Komedi, 2 veya Dram, 3 veya Korku, 4 veya Romantik
             * Girdiğinde Hangi reyonda bu kitaplar bulunur onu yazdırın.
             * Örneğin Kullanıcı aksiyon dedi Aksiyon  A reyonundadır. Kullanıcı 0 dedi Aksiyon A reyonundadır.
             */
            Console.WriteLine("Kitap kategorisi girin (Aksiyon, Komedi, Dram, Korku, Romantik): ");
            string ara = Console.ReadLine();
            KitapKategori kategori = (KitapKategori)Enum.Parse(typeof(KitapKategori), ara);
            switch (kategori)
            {
                case KitapKategori.Aksiyon:
                    Console.WriteLine("Aksiyon kitapları A reyonundadır.");
                    break;
                case KitapKategori.Komedi:
                    Console.WriteLine("Komedi kitapları B reyonundadır.");
                    break;
                case KitapKategori.Dram:
                    Console.WriteLine("Dram kitapları C reyonundadır.");
                    break;
                case KitapKategori.Korku:
                    Console.WriteLine("Korku kitapları D reyonundadır.");
                    break;
                                    case KitapKategori.Romantik:
                    Console.WriteLine("Romantik kitapları E reyonundadır.");
                    break;
                default: Console.WriteLine("Uygun kategori bulunamadı."); break;
            }

        }
    }
    enum KitapKategori { Aksiyon, Komedi, Dram, Korku, Romantik }
    enum Markalar : byte { Honda = 1, Toyota, Bmw, Mercedes, Audi = 5, Opel = 9, Ford, Renault, Fiat, Skoda }
    enum Vitesler { Manuel, Otomatik, YarıOtomatik }

    class Otomobil
    {
        public Markalar Marka { get; set; }
        public Vitesler Vites { get; set; }
        public string Renk { get; set; }
        public int UretimYili { get; set; }
        public string Model { get; set; }
        public string YakitTipi { get; set; }

        public void OzellikleriYazdir()
        {
            Console.WriteLine($"Marka: {Marka} Vites: {Vites} " +
                $"Renk: {Renk} Üretim Yılı: {UretimYili}" +
                $" Model: {Model} Yakıt Tipi: {YakitTipi}");
        }
    }
}
