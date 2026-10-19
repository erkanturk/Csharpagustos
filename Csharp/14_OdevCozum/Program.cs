namespace _14_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            /* Bir method tanımlayacağız indirim diye kullanıcıdan 2 ürün fiyatı girmesini isteyeceğiz
             * Girilen fiyatlardan ucuz olana %30 indirim uygulayacağız ve kullanıcıya 3. üründe %50 indirim olduğunu söyleyeceğiz
             * Kullanıcıdan alınan cevaba göre 3. ürünü almak isterse 3. ürünün fiyatını isteyeceğiz ve 
             * 1 2 3 ürünün fiyatlarını işlem yapılmış halinin toplamını ekrana yazdıracağız 
             * eğer 3. ürünü istemezse 1. ve 2. ürünün fiyatları görünecek.
             */
            //Indirim();
            #endregion
            #region Ödev 2
            //Rastgele 1-100 arasında değer oluşturun ve bu değerleri
            //15 değer tutan bir diziye aktaralım  ve bu dizideki tek ve çift sayıları ayrı ayrı diziye
            //Aktaran method yazılacak ve tek ve çift sayıları ayrı ayrı ekrana yazdıracak dizinin kendisinide 
            DiziDoldur();
            #endregion
        }
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatı");
            double f1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatı");
            double f2 = Convert.ToDouble(Console.ReadLine());
            if (f1 > f2)
            {
                f2 *= 0.70;

            }
            else
            {
                f1 *= 0.70;

            }
            Console.WriteLine("Üçüncü üründe %50 indirim var ister misin ? (E/H)");
            string cevap = Console.ReadLine().ToUpper().Trim();

            if (cevap == "E")
            {
                Indirim2(f1, f2);
            }
            else if (cevap=="H")
            {
                Console.WriteLine($"Ödeme {f1+f2}");
            }
            else
            {
                Console.WriteLine("Hatalı işlem");
            }
        }
        static void Indirim2(double f1, double f2)
        {
            Console.WriteLine("3.Ürün Fiyatı");
            double f3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ödeme {f1+f2+(f3/2)}");
        }
        static void DiziDoldur()
        {
            int[] tekSayilar = new int[0];
            int[] ciftSayilar = new int[0];
            int[] rsayilar= new int[15];
            Random r = new Random();
            for (int i = 0; i < rsayilar.Length; i++)
            {
                int sayi = r.Next(1,101);
                rsayilar[i] = sayi;
                if (sayi % 2 == 0)
                {
                    Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
                    ciftSayilar[ciftSayilar.Length - 1] = sayi;
                }
                else
                {
                    Array.Resize(ref tekSayilar, tekSayilar.Length + 1);
                    tekSayilar[tekSayilar.Length - 1] = sayi;
                }
            }
            DiziYazdir("Random Sayilar",rsayilar);
            DiziYazdir("Tek Sayilar",tekSayilar);
            DiziYazdir("Çift Sayilar",ciftSayilar);

        }
        static void DiziYazdir(string deger,int[] dizi)
        {
            Console.WriteLine("**********");
            foreach (int item in dizi)
            {
                Console.WriteLine($"{deger}===>{item}");
            }
        }
    }
}
