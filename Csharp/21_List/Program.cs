using System.Threading.Channels;

namespace _21_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List Generic typlar verdiğimiz bize birden fazla veri tutabilen bir yapıdır.
             * List Generic tipler System.Collections.Generic isim alanında bulunur
             * List Generic tipler de Arraylist gibi referans tiplerdir.
             * List yapısı da dinamik uzunluğa sahiptir 2 üzeri n
             * ArrayList den farklı olarak type safe  bir yapıdadır
             * İndexlenebilirler
             * Aynı türde verileri tutmak için kullanılır
             * Performans açısından ArrayList yapısından hızlıdır
             * Linq sorguları ile kullanılabilir
             * içerisinde her tipi generic olarak barındırır
             * Type safe  yani tip güvenliğini sağlayan şey generic olması ve bu sayede
             * hem her değeri içeriside barındırabilir hemde bu değerler boxing unboxing olarak kullanılmaz
             * doğrudan kendi veri tipleri üzerinden kullanılırlar
             * <> generic tip belirtmek için  bu işaret kullanılı List<string> olarak yazılır.
             */
            // Lamda expression => hızlı fonksiyon tanımlama yapısıdır 

            #region 
            List<string> list = new List<string>();
            list.Add("Batıkan");
            list.Add("İdil");
            list.Add("Melek");
            list.Add($"Erkan {25}");
            list.AddRange(new List<string>() { "Kübra", "Yiğit", "Süreyya", "Erkan" });

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            List<int> yaslar = new List<int>() { 20, 20, 30, 30, 14, 14, 22, 22, 33, 33, 15, 52, 77, 16, 17 };
            //foreach (int item in yaslar)
            //{
            //    Console.WriteLine(item);
            //}
            //where ifadesi koşul yapısıdır  tolist ise liste halinde getirmeyi sağlar
            //yaslar.Where(x => x > 17).ToList().ForEach(x => Console.WriteLine(x));
            //int yas = yaslar.FirstOrDefault();//yaşlar listesine git ilk bulduğunu getir.
            //Console.WriteLine("*********");
            //int bul = yaslar.Find(abc => abc == 22);
            //Console.WriteLine(bul);
            //Console.WriteLine("**********");
            //Console.WriteLine(yas);
            //Yaz();
            //Console.WriteLine(Yas());
            //Yaşların bana toplamını ortalamasını  getiren kod 
            //int toplam = 0;
            //foreach (int item in yaslar)
            //{
            //    toplam += item;
            //}
            //Console.WriteLine(toplam);
            //Console.WriteLine(toplam / yaslar.Count);

            //int toplam2 = yaslar.Where(x => x > 20).Sum();//sum elemanları toplar
            //Console.WriteLine(toplam2);
            //Console.WriteLine(yaslar.Average());//average ise ortalamasını alır.

            ////Console.WriteLine(yaslar.FirstOrDefault(y => y > 22));
            //int[] degerler = yaslar.Where(a => a > 30).ToArray();
            //foreach (var item in degerler)
            //{
            //    Console.WriteLine(item);
            //}

            //yaslar.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine("***********");
            //yaslar.OrderBy(x => x).ToList().ForEach(y => Console.WriteLine(y));
            //Console.WriteLine("***********");
            //yaslar.OrderByDescending(x => x).ToList().ForEach(y => Console.WriteLine(y));
            //Console.WriteLine("***********");
            //yaslar.Select(x => x * 2).ToList().ForEach(x => Console.WriteLine(x));
            //Tekilleştirme işlemi
            yaslar.Distinct().OrderByDescending(x=>x).ToList().ForEach(x => Console.WriteLine(x));
            #endregion
        }
        static void Yaz() => Console.WriteLine("Erkan");
        static int Yas() => 14;
    }
}
