using System.Collections;

namespace _19_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SortedList
            /* SortedList
             * Sıralı liste olarak adlandırılır ve anahtar-değer çiftlerini saklayan bir koleksiyon yapısıdır
             * Key değeri daima sabit veri tipi olmalıdır ve benzersiz olmalıdır
             * eğer bir key değeri string ise string olarak diğer key değerleri de verilmelidir
             * Fakat value kısmında böyle bir kısıtlama yoktur dinamik olarak her veriyi tutabilir
             * Bu yapı Dictonary entry yapısına sahip bir koleksiyon yapısıdır (sözlük yapısı)
             * Generic olarak bir yapısıda mevcuttur bu yapıda value yapılarınıda kısıtlamaya tabi tutabiliriz.
             * Sözlük yapısında var olan bir değerin key değeri ile güncellemesi mümkündür
             * Sözlükte olmayan bir değer ise bu yapı eklemesi gerçekleştirilir.
             * Add ifadesinden sonra ilk verilen değer daima key değeridir bu değerin karşılığında value değerini yazarız.
             */

            #endregion
            #region Örnek 1
            SortedList sortedList = new SortedList();
            //sortedList.Add("istanbul", 34);
            //sortedList.Add("ankara", "06");
            //sortedList.Add("izmir", 35);
            //sortedList.Add("adana", 01);
            //sortedList.Add("antalya", 07);
            //sortedList.Add(16, "Bursa");//Sıralı bir yapıda olduğu için burada key değerlerine göre sıralamayapar
            //metinsel bir key ile başladıysak sayısal devam edemeyiz hata verir.

            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in sortedList.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in sortedList.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Value + "=>" + item.Key);
            //}

            //Console.WriteLine(sortedList.ContainsKey("adana"));
            //Console.WriteLine(sortedList.ContainsValue("16"));

            //Console.WriteLine(sortedList["adana"]);
            //Console.WriteLine(sortedList["06"]);

            //sortedList["Adana"] = 01;//yoksa ekle varsa günceller
            //sortedList["ankara"] = 75;//olan değer güncellendi
            //sortedList.Remove("Adana");
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}

            //sortedList.Add(1, true);
            //sortedList.Add(7, false);
            //sortedList.Add(2, "A");
            //sortedList.Add(3, "B");
            //sortedList.Add(4, 'B');
            //sortedList.Add(5, DateTime.Now);
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}
            SortedList<int, char> liste = new SortedList<int, char>();

            liste.Add(1, 'a');
            liste.Add(2, 'B');
            liste.Add(3, 'b');
            liste.Add(4, 'c');
            liste.Add(5, 'd');
            liste.Add(6, 'f');

            foreach (KeyValuePair<int, char> item in liste)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            #endregion

            #region Ödev
            /* Sözlük uygulaması TR-EN
            * sozluk.Add("kitap", "book");
            * 1-Arama
            * 2-Çıkarma
            * 3-Listeleme
            * 4-Çıkış
            * Kullanıcıya bu seçimlerden birini yönlendirelim
            * ve seçimine göre işlemler yapalım
            * Eğer arama derse kullanıcı türkçe olarak girdiği 
            * kelimenin ingilizce karşılığını görecek
            * Eğer bu kelime sözlükte yoksa kullanıcıya bu 
            * kelimenin sözlükte bulunmadığını söyleyelim ve 
            * Sözlüğe eklemek isteyip istemediğini soralım 
            * eğer kullanıcı eklemek isterse bu kelimeyi sözlüğe ekleyelim
            * Çıkarmak isterse türkçe olarak girdiği kelimenin
            * ingilizce karşılığını sözlükten çıkaralım
            * 
            * 
            */
            //Key değeride string value değeridi string
            #endregion
        }
    }
}
