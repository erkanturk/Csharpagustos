namespace _13_Methods_6_Optional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Optional Methods
             * Normal method yapısında bir parametre varsa bu parametre değeri verilmesi zorunludur.
             * Fakat bu parametre değerinin verilmeme durumu olması için isteğe bağlı parametre tanımlanması gerekir
             * 
             * Örneğin bir stee cinsiyet değeri belirtmek istemiyoruz ama bu değerin tutulması lazım
             * sizin belirtmek istemediğiniz değeri site veri tabanı yine tutacak 
             * ama siz bu değeri göndermeden de işlem yapmanız gerekiyor
             * bu doğrultuda parametrelere değer varsayılan olarak atanır
             * İsteğe bağlı parametreler mutlaka son parametreler olmak zorundadır 
             * Zorunlu parametrenin öndünde isteğe bağlı parametre bulunamaz
             * istediğimiz miktarda isteğe bağlı parametre yapabiliriz.
             */
            #region örnek1
            //UrunKaydet2("Klavye", "Logitech", 10, "Aksesuar");
            //UrunKaydet("Mouse", "Logitech", 10);//Kategori belirtmediğimiz için varsayılan değeri kullandı

            //UrunKaydet("Kulaklık", "Logitech", 10,"Bilgisayar Aksesuar");//Eğer değer verirsem benim belirtiğimi kullan 
            #endregion
            //("01.01.1990");
            //Personel("Erkan Türk", 32, time);

            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doğum tarihi");
            DateTime time = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Meslek");
            string meslek = Console.ReadLine();
            Console.WriteLine("Ülke");
            string ulke = Console.ReadLine();
            Console.WriteLine("Cinsiyet");
            string cinsiyet = Console.ReadLine();
            //Personel(ad, y, time, meslek, ulke, cinsiyet);

            //Personel(ad, y, time, meslek, cinsiyet);

            Personel(adSoyad: ad, yas: y, dogumTarihi: time, meslek: meslek, cinsiyet: cinsiyet);

            //Console.WriteLine(value:(object)10);

        }
        #region ÖRnek 1
        static void UrunKaydet(string urunAdi, string marka, int stok, string kategori = "Elektronik")
        {
            Console.WriteLine($"ürün adı:{urunAdi} marka {marka} stok {stok} kategori {kategori}");
        }
        static void UrunKaydet2(string urunAdi, string marka, int stok, string kategori)
        {
            Console.WriteLine($"ürün adı:{urunAdi} marka {marka} stok {stok} kategori {kategori}");
        }
        #endregion

        static void Personel(string adSoyad, int yas, DateTime dogumTarihi, string meslek = "Belirtmek istemiyor",
            string ulke = "Türkiye", string cinsiyet = "Belirtmek istemiyor")
        {
            Console.WriteLine($"Ad Soyad:{adSoyad} \nYaş:{yas} \nDoğum Tarihi:{dogumTarihi} \nMeslek:{meslek}\nÜlke:{ulke}\nCinsiyet:{cinsiyet}");
        }
    }
}
