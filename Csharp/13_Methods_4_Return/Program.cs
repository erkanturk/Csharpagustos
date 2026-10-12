namespace _13_Methods_4_Return
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
            #endregion
            #region Ödev 2
            //Rastgele 1-100 arasında değer oluşturun ve bu değerleri
            //15 değer tutan bir diziye aktaralım  ve bu dizideki tek ve çift sayıları ayrı ayrı diziye
            //Aktaran method yazılacak ve tek ve çift sayıları ayrı ayrı ekrana yazdıracak dizinin kendisinide 

            #endregion

            //int yaz = Deger(50, 50);
            //yaz *= 2;
            //Console.WriteLine(yaz);

            //Console.WriteLine("1.Sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //int s = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayı");
            //int s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("4.Sayı");
            //int s3 = Convert.ToInt32(Console.ReadLine());

            //foreach (int i in Sayilar(s2, s3, s, sayi))
            //{
            //    Console.WriteLine(i*2);
            //}


            // Console.WriteLine(Degerler(1,100));

            //char[] x = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G' };
            //foreach (var item in Ascii(x))
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var metin in Test("Bugün hava çok güzel"))
            //{
            //    Console.WriteLine(metin);
            //}
            //Console.WriteLine(Personel("Erkan","Türk",32,4000));
            Console.WriteLine(TubleMethod(10,20.5));
        }
        //static int[] Ascii(char[] dizi)
        //{
        //    int[] sayilar = new int[dizi.Length];
        //    for (int i = 0; i < dizi.Length; i++)
        //    {
        //        sayilar[i] = dizi[i];
        //    }
        //    return sayilar;
        //}

        //static int[] Test(string dizi)
        //{

        //    int[] sayilar = new int[dizi.Length];
        //    for (int i = 0; i < dizi.Length; i++)
        //    {
        //        sayilar[i] = Convert.ToChar(dizi[i]);
        //    }
        //    return sayilar;
        //}
        //static string Personel(string ad, string soyad, int yas, double maas)
        //{
        //    return $"{ad} {soyad} {yas} {maas}";
        //}


        //static int Deger(int sayi, int sayi2)
        //{
        //    return sayi + sayi2;
        //}
        //static int[] Sayilar(int sayi, int sayi2, int sayi3, int sayi4)
        //{
        //    int[] dizi = new int[4];
        //    dizi[0] = sayi;
        //    dizi[1] = sayi2;
        //    dizi[2] = sayi3;
        //    dizi[3] = sayi4;

        //    return dizi;
        //}
        //static Random Degerler(int sayi,int sayi2)
        //{
        //    Random rnd= new Random();
        //    rnd.Next(sayi, sayi2);
        //    return rnd;
        //}
        static (int, double) TubleMethod(int sayi,double sayi2)
        {
            return (sayi, sayi2);
        }

    }

}
