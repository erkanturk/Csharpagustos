namespace _10_Donguler_4_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            /* Sistem tarafından random sayı üreteceğiz 1 ila 100 arasında olacak 100 de dahil olacak
             * kullanıcıdan bu sayıyı tahmin etmesini isteyeceğiz
             * toplamta 5 tahmin hakkı olacak
             * kullanıcının girdiği sayı random sayıdan büyük ise ekrana "Daha küçük bir sayı giriniz" yazacak
             * kullanıcının girdiği sayı random sayıdan küçük ise ekrana "Daha büyük bir sayı giriniz" yazacak
             * doğru tahmin yaparsa ekrana "Tebrikler doğru tahmin" yazacak ve döngü sonlanacak
             * kullanıcı 5 tahmin hakkını da kullanırsa ekrana "Tahmin hakkınız bitti. Doğru sayı
            */
            #endregion
            Random random = new Random();
            int rSayi = random.Next(1, 101);
            int hak = 5;

            while (true)
            {
                Console.WriteLine("Şanslı tahmininizi giriniz.");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                hak--;

                if (rSayi == tahmin)
                {
                    Console.WriteLine("Tebrikler doğru tahmin:" + tahmin);
                    Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
                    string cevap = Console.ReadLine();

                    if (cevap.ToUpper() == "E")
                    {
                        rSayi = random.Next(1, 101);
                        hak = 5;
                        Thread.Sleep(1000);
                        Console.WriteLine("Oyun tekrar başlıyor lütfen bekleyin");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            
                            Console.Clear();

                        }
                        continue;
                    }
                    else if (cevap.ToUpper() == "H")
                    {
                        Console.WriteLine("Oyun sonlanıyor");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                           
                            Console.Clear();

                        }
                        break;
                    }
                }
                else if (rSayi > tahmin)
                {
                    Console.WriteLine("Lütfen daha büyük sayı giriniz");
                }
                else if (rSayi < tahmin)
                {
                    Console.WriteLine("Lütfen daha küçük sayı giriniz");
                }
                if (hak == 0)
                {
                    Console.WriteLine("Hakkınız kalmadı random sayı:" + rSayi);
                    Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
                    string cevap = Console.ReadLine();
                    if (cevap.ToUpper() == "E")
                    {
                        rSayi = random.Next(1, 101);
                        hak = 5;
                        Thread.Sleep(1000);
                        Console.WriteLine("Oyun tekrar başlıyor lütfen bekleyin");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            
                            Console.Clear();

                        }
                        continue;
                    }
                    else if (cevap.ToUpper() == "H")
                    {
                        Console.WriteLine("Oyun sonlanıyor");
                        for (int i = 5; i > 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            
                            Console.Clear();

                        }
                        break;
                    }
                }
            }
        }
    }
}
