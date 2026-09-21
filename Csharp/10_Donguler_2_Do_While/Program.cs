namespace _10_Donguler_2_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Do while 
             * Koşul false olsa dahi bir defa çalışan döngü yapısıdır
             * Koşul true ise devam eder fakat ilk program çalıştığında yapının false olması durumunda 1 defa döngü tetiklenir
             * Devamını getirmez.
             */
            #region Örnek 1
            //int sayac = 1;
            //do
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //} while (sayac>10);//Koşul false

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);



            #endregion
            //Kullanıcı 0 girene kadar girdiği tüm sayıları toplasın
            //eğer kullanıcı 0 a basarsa girdiği sayıların toplamı ekrana yazdırılsın
            //if else kullanılmayacak.
            int sayi;
            int toplam=0;
            int sayac = 1;
            do
            {
                Console.WriteLine($"{sayac}.Sayıyı giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                sayac++;
            } while (sayi != 0);
            Console.WriteLine(toplam);
           
        }
    }
}
