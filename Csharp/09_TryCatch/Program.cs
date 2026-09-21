namespace _09_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* TryCatch(Dene Yakala)
             * Try yapısında yazdığımız kod blokları kontrol edilir bu alanda kullanıcı kaynaklı yada sistemsel yada kullanılan veritipi
             * kaynaklı hatalar veri tipinin değeri aşması vb bir çok yapı kontrol edilir
             * eğer bu değerlerde bir hata var ise try yapısı bu hatayı algılar ve catch yapısına bildirir.
             * catch yapısı bize alternatif çözümler sunar yada hatayı gösterir
             * bu yapı programın çökmesini engeller ve hataları yakalar.
             * Trycatch yapısı syntax hatalarını yakalamaz.
             */
            #region örnek 1 

            //Console.WriteLine("bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. sayı değeri");
            //int sayi2= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi/sayi2);
            //try bloğunun içinde tanımlanan bir değişken sadece try alanında kullanılır
            //try dışında kullanacaksak try dışarısında tanımlanması gerekmektedir.
            //Hatayı hangi satırda aldıysak aşağısındaki kodları okumaz.
            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2. sayı değeri");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi + sayi2);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Hata {ex.Message}");
            //}
            //Console.WriteLine("Program çalışmaya devam eder");

            int a = 5;
            int b = ++a;
            int c = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            #endregion
        }
    }
}
