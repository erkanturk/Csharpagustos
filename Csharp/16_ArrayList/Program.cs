using System.Collections;

namespace _16_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList
             * Dizilere benzer olarak içerisinde birden çok veriyi barındıran data yapılarıdır.
             * int[],string[],char[] gibi arrayler içerisinde sadece ilgili data tiplerini tutabilirken
             * Collections yapıları daha spesifik ve karmaşık yapılarıda beraberinde içerisinde tutabilir.
             * Dizilerdne farklı olarak bir veri tipi belirtmemize gerek kalmaz ve maksimum uzunluk değeri 2 üzeri n olarak artar.
             * System.Collections yapısını kullanırlar ve ICollection ve IEnumarable yapısını implemente etmiş durumdadır
             * Koleksiyon yapıları=> ArrayList,Stack,Queue,SortedList,HashTable,List(Generic)
             * ArrayList Çalışma prensibi Boxing Unboxin olarak çalışır.
             * ArrayList Generic Bir yapıda değildir Generic yapısını kullanamaz.
             */

            #region Boş ArrayList
            //ArrayList arrayList = new ArrayList();//Örneklem nesne oluşturma  instance
            //arrayList.Add("Erkan");
            //arrayList.Add("Türk");
            //arrayList.Add(true);
            //arrayList.Add('A');
            //arrayList.Add(DateTime.Now);
            //arrayList.Add(123);
            //arrayList.Add(123.456m);
            //arrayList.Add(123.456f);
            //arrayList.Add(123.456);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item.GetType()+"=>"+item);
            //}
            //Console.WriteLine(arrayList.Count);
            //Console.WriteLine(arrayList.Capacity);
            //Console.WriteLine(arrayList[1]);
            #endregion
            #region Dolu ArrayList
            //ArrayList list = new ArrayList() { "erkan", "Türk", 123, 1234.456, 'A', DateTime.Now };
            //list.Add("Test");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region ArrayList Methodları
            //ArrayList list = new ArrayList();
            #region Silme işlemi ve çoklu ekleme
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.AddRange(new ArrayList { "Erkan", "Batıkan", "İdil","Melek","Emin","Kübra","Yiğit" });
            //D(list);
            // list.Clear();
            //D(list);
            //list.Remove("Erkan");//value ya göre silme
            //list.RemoveAt(3);//index değerine göre silme
            //list.RemoveRange(3,5);//belli aralıkta silme
            //D(list);
            #endregion
            #region Ekleme
            //list.Insert(0, "Erkan");
            //string[] adlar = { "Tahsin", "Altan", "Onur" ,"Furkan"};
            //list.InsertRange(0, adlar);//belirtilen indexten itibaren ekle
            //D(list);
            #endregion
            #region Reverse&Sort
            //ArrayList sayilar = new ArrayList() { 100, 311, 533, 74, 9, 10, 11, 12, 13, 14 };
            ////sayilar.Sort();
            //sayilar.Reverse();
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Indexof&LastIndexof
            //ArrayList iller = new ArrayList() { "Adana", "Amasya", "Trabzon", "Tokat", "Sivas", "Amasya", "Zonguldak", "Amasya", "Ankara", "Amasya", "Amasya" };
            //Console.WriteLine(iller.IndexOf("Amasya"));//ilk bulduğu değeri getirir
            //Console.WriteLine(iller.IndexOf("Amasya", 2));//belirtilen index değerinden itibaren arar
            //Console.WriteLine(iller.LastIndexOf("Amasya"));
            //Console.WriteLine(iller.LastIndexOf("Amasya", 8));

            //for (int i = 0; i < iller.Count; i++)
            //{
            //    if (iller[i] == "Amasya")
            //    {
            //        Console.WriteLine(iller[i]+"index=>"+i);
            //    }
            //}
            #endregion
            #region 
            ArrayList iller = new ArrayList() { "Adana", "Amasya", "Trabzon", "Tokat", "Sivas", "Amasya", 
                "Zonguldak", "Amasya", "Ankara", "Amasya", "Amasya" };
            bool varMi = iller.Contains("Amasya");
            Console.WriteLine(varMi);
            string ara = iller.Contains("Adana") ? "Var" : "Yok";
            Console.WriteLine(ara);

            object[] veriler = iller.ToArray();//Diziye çevirme
            foreach (var item in veriler)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region 
            #endregion
            #endregion


        }

        static void D(ArrayList list)
        {
            Console.WriteLine("******");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
