namespace _11_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Diziler(Array) string ifadeler aslında birer dizidir. Erkan => içinde birden çok eleman taşır.
             * Dizilerde birden çok yapıyı içinde barındıran bir collection yapısıdır.
             * Dizileri tanımlarken eleman sayısını belirtmemiz gerekir yada belirtmediğimiz durumlarda bu değer sonradan belirlenir.
             * Mutlaka uzunluk miktarları olmalıdır.
             * Dizilerin elemanlarını çağırırken yada güncelleme durumlarında index adı verilen key değerlerini kullanarak işlem yaparız.
             * !!!! İndexler Daima 0 dan başlar!!!!
             * Dizi tanımlama yapısında bir veri tipi bilirtiriz isim veririz new keywordu ve uzunluk miktarı belirtiriz bu uzunluk
             * Kullanıcı tarafından da alınabilir.
             * Dizi tanımı 
             * int[] dizi = new int[uzunluk]
             * Diziler tek tip eleman alır 
             * Diziler dolu veya boş olarak iki farklı biçimde kullanılabilinir.
             */
            #region Örnek1
            //string isim = "Erkan";
            //Console.WriteLine(isim[3]);
            //E,i=>0  Eleman sayısı=>1 r=>1,Eleman sayısı=>2 k=>2,Elemansayısı=3 a=>3,Elemansayısı=>4 n=>4,Eleman sayısı=>5
            //index=>0,1,2,3,4
            //Eleman=>1,2,3,4,5

            //string[] adlar = new string[5];//boş dizi
            //index=>         0   1   2   3   4   5             
            //int[] yaslar = {60, 20, 30, 40, 50, 60 };//dolu dizi 
            //Length (eleman)  1   2   3   4   5   6

            //adlar[4] = "Batıkan";//boş diziye eleman ekleme
            //adlar[2] = "İdil";
            //adlar[1] = "Emin";
            //adlar[0] = "Kübra";
            //adlar[4] = "Erkan";
            ////adlar[5] = "Yiğit";//Hata verir:System.IndexOutOfRangeException:index aşımı hatası:
            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i]);
            //}

            //for (int i = 0; i < yaslar.Length; i++)
            //{
            //    Console.WriteLine(yaslar[i]);
            //}
            //Console.WriteLine(adlar[4]);


            #endregion
            #region Örnek2
            //int[] sayilar = new int[10];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = i + 10;
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.WriteLine("**************");
            //int index = 0;
            //while (index<sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[index]);
            //    index++;
            //}
            #endregion
            #region Personel
            //Kullanıcıya kaç adet personeli olduğunu soralım bu personelleri bir diziye aktaralım
            //Aktarma işleminden sonra  her bir personeli ekrana yazdıralım
            //Örneğin 1.Personel Erkan 2.Personel  Emin
            //Console.WriteLine("Kaç personeliniz var");
            //int personel = Convert.ToInt32(Console.ReadLine());
            //string[] ad = new string[personel];//kullanıcının verdiği sayı değeri kadar benim dizimin uzunluğu olacak.
            //string[] soyad = new string[personel];
            //for (int i = 0; i < ad.Length; i++)//Uzunlukları aynı olmayan dizileri tek bir döngü ile gösteremeyiz.
            //{
            //    Console.WriteLine($"{i + 1}.Personel Adı");
            //    ad[i] = Console.ReadLine();
            //    Console.WriteLine($"{i + 1}.Personel Soyadı");
            //    soyad[i] = Console.ReadLine();
            //}

            //Console.WriteLine("****************");
            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Personel Ad {ad[i]} Soyad {soyad[i]}");
            //}
            //int x = 0;
            //Console.WriteLine("********");
            //foreach (string isim in ad)
            //{
            //    Console.WriteLine($"{isim} {soyad[x]}");
            //    x++;
            //}

            #endregion
            #region Foreach
            //string[] sehirler = { "İzmir", "Adana", "İstanbul", "Amasya", "Tokat", "Sivas", "Yozgat", "Bursa", "Samsun", "Trabzon" };

            //int j = 0;
            //while (j < sehirler.Length)
            //{
            //    Console.WriteLine("While=> " + sehirler[j]);
            //    j++;
            //}
            //Console.WriteLine("************");
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine("For=> " + sehirler[i]);
            //}

            //Console.WriteLine("***************");
            //j = 0;//index değerini sıfırlıyoruz diziyi tekrar yazdırmak için
            //do
            //{
            //    Console.WriteLine("Do While=> " + sehirler[j]);
            //    j++;
            //} while (j<sehirler.Length);
            //Console.WriteLine("********");
            //foreach (string il in sehirler)
            //{
            //    Console.WriteLine("Foreach=> "+ il);
            //}

            #endregion

            string[] sehirler = { "İzmir", "Adana", "İstanbul", "Amasya", "Tokat", "Sivas", "Yozgat", "Bursa", "Samsun", "Trabzon","Yozgat","Adana","Yozgat" };
            #region Array Methodlar
            #region Clear
            //// var olan dizideki tüm elemanları temizler
            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}
            ////Array.Clear(sehirler);//Mevcut dizinin içindeki tüm elemanları temizler.
            //Array.Clear(sehirler,1,3);//1.indexden başla 3 eleman sil
            //Console.WriteLine("********");
            //foreach (string item in sehirler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Copy
            //string[] iller = new string[sehirler.Length];
            //Array.Copy(sehirler, iller, 4);//4 eleman uzunluğunda aktarım yapacak
            //Array.Copy(sehirler, 3, iller, 5, 4);
            //Array.Copy(sehirler, iller, sehirler.Length);
            //foreach (string item in iller)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region IndexOf&&LastIndexOf
            //int index = Array.IndexOf(sehirler, "Yozgat");//İlk bulduğu değeri getirir.
            //int index2 = Array.IndexOf(sehirler, "Yozgat", 7);
            //Console.WriteLine(index);//-1 olmayan index değeridir.
            //Console.WriteLine(sehirler[index]);
            //Console.WriteLine(index2);
            int lastIndex = Array.LastIndexOf(sehirler, "Yozgat");//diziye sondan bakarak indexleri getirir.
            int lastIndex2 = Array.LastIndexOf(sehirler, "Yozgat", 9);
            Console.WriteLine(lastIndex);
            Console.WriteLine(lastIndex2);

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    if (sehirler[i] == "Yozgat")
            //    {
            //        Console.WriteLine(sehirler[i]+" indexleri "+i);
            //    }
            //}
            
            #endregion
            #region Sort&&Reverse
            #endregion
            #region Contains
            #endregion
            #region Resize
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #region 
            #endregion
            #endregion
        }
    }
}
