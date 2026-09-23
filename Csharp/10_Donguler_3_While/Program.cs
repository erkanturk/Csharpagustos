namespace _10_Donguler_3_While
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
            /* while koşul true olduğu sürecede çalışır false olduğunda sonlanır.
             */
            #region Örnek1
            //int sayi = 0;
            //while (sayi < 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //Console.WriteLine("*************");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("************");
            //int j = 0;
            //do
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}
            //while (j<10);
            #endregion
            #region Sonsuz Dongu
            //while (true)
            //{
            //    Console.WriteLine("Devam etmek istiyor musun ? E H");
            //    string cevap = Console.ReadLine();
            //    if (cevap.ToUpper() == "E")
            //    {
            //        Console.WriteLine("Devam ediyor");
            //    }
            //    else
            //    {
            //        break;

            //    }

            //}
            //Console.WriteLine("Döngü bitti");
            #endregion
            #region Örnek2
            //char harf = 'A';
            //char harf2 = 'z';
            //while ('A'<='z')
            //{
            //    Console.WriteLine(harf);
            //    harf++;
            //}
            #endregion
            #region Örnek3
            //Kullanıcıdan bir metin girmesini isteyelim kullanıcının girdiği metinin her bir karakterini ekrana yukarıdan aşağıya yazdıralım.
            // Console.WriteLine("Bir metin giriniz");
            //string metin = Console.ReadLine();

            //int index = 0;//index değerleri daima 0 dan başlar

            //while (index < metin.Length)
            //{
            //    Console.WriteLine(index+1 +" eleman değeri "+metin[index]+" index "+index);
            //    index++;

            //}
            //Console.WriteLine();
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    Console.WriteLine(metin[i]);
            //}
            #endregion
         
        }
    }
}
