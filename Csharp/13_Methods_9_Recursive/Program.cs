namespace _13_Methods_9_Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Recursive(yineleyen) Method yapısı
             * Büyük bir yapının tamamını yapmak yerine bu işi küçük parçalara bölüp her seferinde bir kısmını 
             * yapmaya yarayan yapıdır.
             * Method koşul içerisinde olmalıdır.
             * Tekrar tekrar kendini çağırır
             * Fakat bu yapıda method yapısı 4 defa çağırılacaksa daima +1 eklenir.
            */
            //Yaz();//Hatalı yapım
            Console.WriteLine("Kayıt işlemleri Çoklu kayıt için 1 tekli kayıt için 2 Döngü form için 3");
            string islem = Console.ReadLine();
            if (islem == "1")
            {
                Console.WriteLine("Kaç kayıt gireceksin");
                int kayit = Convert.ToInt32(Console.ReadLine());
                CokluForm(kayit);
            }
            else if (islem == "2")
            {
                Form();
            }
            else if (islem == "3")
            {
                Console.WriteLine("Kaç kayıt gireceksin");
                int kayit = Convert.ToInt32(Console.ReadLine());
                Form2(kayit);
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama");
            }
        }
        //static void Yaz()
        //{
        //    Console.WriteLine("Merhaba");
        //    Yaz();//Hatalı yazım
        //}
        static void Form()
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Adınız:{ad}\nSoyadınız:{soyad}\nYaşınız:{yas}");
        }
        static void CokluForm(int sayi)
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınız");
            //int yas = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)//Lifo Last in First Out 
            {
                CokluForm(sayi-1);
            }
            Console.WriteLine($"{sayi}.Kayıt\nAdınız:{ad}\nSoyadınız:{soyad}");
        }
        static void Form2(int sayi)
        {
            string ad="";
            string soyad="";
            int yas=0;
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Adınız");
                ad = Console.ReadLine();
                Console.WriteLine("Soyadınız");
                 soyad= Console.ReadLine();
                Console.WriteLine("Yaşınız");
               yas = Convert.ToInt32(Console.ReadLine());
            }
         
            Console.WriteLine($"Adınız:{ad}\nSoyadınız:{soyad}\nYaşınız:{yas}");
        }


    }
}
