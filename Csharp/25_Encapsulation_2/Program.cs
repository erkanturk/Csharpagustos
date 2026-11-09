namespace _25_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proje Ödev

            /* ******** RESTAURANT OTOMASYONU **********
            Masa Siparişler Yemek Yönetici
            Toplam 5 Masa olacak
            ANAMENU
            1-Sipariş Al
            2-Hesap Al
            3-Menü Düzenle
            4-Çıkış
            
            Her gelen müşteri ilk boş masaya oturtulacak
            Kaç kişisiniz diye sorulacak ve her kişiye ayrı ayrı menü yazdırılarak yemek seçmesi istenecek.
            Yemek seçimi sonrası başka bir arzunuz var mı diye sorulacak.
            Evet -> Tekrar menü yazdır ve yemek siparişi al
            Hayır -> 1.masa 2. müşteri için aynı işlemleri yap
            Masadaki herkesin siparişi alındıysa tekrar ana menüye dön   
             */
            #endregion
            //Araba araba = new Araba();
            //araba._Hiz = 100;
            //araba._Hiz = 300;

            //araba._Hiz = -100;
            //Thread.Sleep(2000);
            //araba.Hizlan(10);

            //Thread.Sleep(2000);
            //araba.Hizlan(10);
            //Thread.Sleep(1000);

            //araba.Hizlan(100);
            //Thread.Sleep(1000);
            //araba.Hizlan(100);

            //araba.Yavasla(20);
            //Thread.Sleep(1000);
            //araba.Yavasla(20);
            //Thread.Sleep(1000);
            //araba.Yavasla(20);
            //Thread.Sleep(1000);
            //araba.Yavasla(20);
            //Thread.Sleep(1000);
            //araba.Yavasla(100);
            //Thread.Sleep(1000);
            //araba.Yavasla(100);
            //Thread.Sleep(1000);

            Kisi kisi = new Kisi();
            Console.WriteLine(kisi._Ad);
            kisi._Yas = 17;
            kisi._Yas = 121;
            kisi._Yas = 23;
            kisi._Ad = "Veli";
            kisi._Ad = "";
            kisi._Ad = "Ali";
        }
    }
    class Kisi
    {
        private string Ad { get; set; } = "Veli";
        private int Yas { get; set; }

        public string _Ad
        {
            get => Ad;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Ad Alanı Boş olamaz");
                }
                else if (value.StartsWith("A"))
                {
                    Ad = value;
                    Console.WriteLine(Ad);
                }
                else
                {
                    Console.WriteLine("Ad A ile başlamadı");
                }
            }
        }
        public int _Yas
        {
            get { return Yas; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Yaş 18 den büyük olmalı");
                }
                else if (value > 120)
                {
                    Console.WriteLine("Yaş 18 ila 120 arasında olmalı");
                }
                else if(value<0)
                {
                    Console.WriteLine("Negatif değer girilemez");
                }
                else
                {
                    Yas = value;
                    Console.WriteLine(Yas);
                }
            }
        }
    }
}
