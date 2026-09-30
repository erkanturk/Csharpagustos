namespace _13_Methods_2_Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek dizi Method
            //int[] sayilar = { 1, 2, 3 };
            //int[] sayilar2 = { 10, 20, 30 };
            //int[] sayilar3 = { 100, 200, 300 };
            //string[] adlar = { "Erkan", "Ahmet", "Tahsin", "Altan" };
            //string[] adlar2 = { "Veli", "Onur", "Gökhan", "yiğit" };
            //string[] adlar3 = { "Can", "Efe", "Ali", "Gökhan" };
            //char[] harfler = { 'A', 'B', 'C', 'ç' };
            //char[] harfler2 = { 'D', 'E', 'F', 'G' };
            //char[] harfler3 = { 'U', 'Ü', 'V', 'T' };


            //object[] dizi = { sayilar[0], sayilar[1], sayilar2[2], adlar[0], adlar[1], harfler2[0], harfler[2] };
            //object[] dizi2 = { "Erkan", "Ahmet", "Tahsin", "Altan", 100, 200, 300, 'A', 'B', 'C', 'ç',DateTime.Now,true };
            ////DiziYazdir(sayilar);
            ////DiziYazdir(sayilar2);
            ////DiziYazdir(sayilar3);
            ////DiziYazidir2(adlar);
            ////DiziYazidir2(adlar2);
            ////DiziYazidir2(adlar3);
            ////DiziYazdir3(harfler);
            ////DiziYazdir3(harfler2);
            ////DiziYazdir3(harfler3);
            #endregion
            // Yazdir(dizi2);

            //4 temel method yapısı olacak
            //1. method toplama işlemi yapacak iki sayısal değeri
            //2. method çarpma 
            //3. bölme
            //4. çıkartma
            //Sonuçlarını göstersin

            //Console.WriteLine("1.Sayı");
            //double sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Sayı");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İşlem (+ - * /)");
            //char islem = Convert.ToChar(Console.ReadLine());
            //if (islem == '+')
            //{
            //    Topla(sayi, sayi2);
            //}
            //else if (islem == '-')
            //{
            //    Cikart(sayi, sayi2);
            //}
            //else if (islem == '/')
            //{
            //    Bol(sayi, sayi2);
            //}
            //else if (islem == '*')
            //{
            //    Carp(sayi, sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı seçim");
            //}

            // DiziDoldur(10,20,30,40); dizi isteyen bir methoda 4 tane parametre göndermiş oluruz dizi olarak kabul etmez

            //int[] d = new int[0];
            //Console.WriteLine("Dizinin uzunluğu");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //DiziDoldur(d, sayi);


            int[] yaslar = new int[0];
            string[] adlar = new string[0];
            DiziDoldur2(yaslar, adlar);


        }
        static void DiziDoldur(int[] dizi, int sayi)
        {
            dizi = new int[sayi];
            for (int i = 0; i < sayi; i++)
            {
                //Array.Resize(ref dizi, dizi.Length + 1);
                dizi[i] = i;

            }
            DiziYazdir(dizi);

        }
        static void Topla(double s, double s2)
        {
            Console.WriteLine(s + s2);
        }
        static void Bol(double s, double s2)
        {
            if (s2 == 0)
            {
                Console.WriteLine("Sayı 0 a bölünemez");
            }
            else
            {
                Console.WriteLine(s / s2);
            }

        }
        static void Carp(double s, double s2)
        {
            Console.WriteLine(s * s2);
        }
        static void Cikart(double s, double s2)
        {
            Console.WriteLine(s - s2);
        }

        static void Yazdir(object[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziYazdir(int[] sayilar)
        {
            Console.WriteLine("*********");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
        static void DiziYazidir2(string[] dizi)
        {
            Console.WriteLine("*********");
            foreach (string item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziYazdir3(char[] dizi)
        {
            Console.WriteLine("*********");
            int i = 0;
            while (i < dizi.Length)
            {
                Console.WriteLine(dizi[i]);
                i++;
            }
        }

        static void DiziDoldur2(int[] yas, string[] ad)
        {
            Console.WriteLine("Kaç Kişi kayıt edeceksin");
            int kayit = Convert.ToInt32(Console.ReadLine());
            yas = new int[kayit];

            for (int i = 0; i < yas.Length; i++)
            {
                Array.Resize(ref ad, yas.Length);
                Console.WriteLine("Ad");
                ad[i] = Console.ReadLine();
                Console.WriteLine("Yaş");
                yas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Yazdir(ad, yas);

        }
        static void Yazdir(string[] dizi, int[] dizi2)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"ad:{dizi[i]} yaş:{dizi2[i]}");
            }
        }
    }
}
