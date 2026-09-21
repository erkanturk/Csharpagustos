namespace _07_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ödev
            /* Kullanıcıdan isim yaş çocuk sayısı istenecek 
             * Eğer kullanıcı 45 yaşının altında ise çocuk sayısına bakılacak
             * ve çocuk sayısı 3'ten az ise çocuk başına 2500 tl maaşına ekleme yapılacak
             * 45 in üzerinde ise çocuk başına para verilmeyecek 5000 tl ekleme yapılacak 
             * eğer çocuk sayısı 3 ten fazla ise çocuk başına 2000 tl maaşına ekleme yapılacak 
             * Örneğin çıktı: Erkan Türk Maaşınız 40000 olarak görünecek.
             */
            Console.WriteLine("Ad:");
            string ad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaş");
            double maas= Convert.ToDouble(Console.ReadLine());
            if (yas > 45)
            {
                Console.WriteLine($"Ad:{ad} Yeni Maaş:{maas+5000}");
            }
            else
            {
                Console.WriteLine("Çocuk Sayısı");
                int cocukSayisi = Convert.ToInt32(Console.ReadLine());
                if (cocukSayisi < 3)
                {
                    Console.WriteLine($"Ad:{ad} Yeni Maaş:{maas+(cocukSayisi*2500)}");
                }
                else
                {
                    Console.WriteLine($"Ad:{ad} Yeni Maaş:{maas+(cocukSayisi*2000)}");
                }
            }

        }
    }
}
