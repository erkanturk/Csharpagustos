
using _12_OtomatProjesi;

namespace _14_Etut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Etüt konuları
             * 1-Methodlar
             * 2-Array ve methodları
             * 3-if else 
             * 4-switch case

             */


            #region Konu 1 If Else
            //int yas = 13;
            //if (yas > 18)
            //{
            //    Console.WriteLine("Yaş büyüktür");
            //}
            //else if (yas >= 13)
            //{
            //    Console.WriteLine("Yaş 13 den büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("Yaş bilgisi 13 den küçüktür.");
            //}

            //Console.WriteLine("Birinci ürün fiyatı");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci ürün fiyatı");
            //double fiyat2= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Üçüncü ürünü almak ister misin indirim var? (E/H)");
            //string cevap = Console.ReadLine().ToUpper();
            //double fiyat3;
            //if (cevap == "E")
            //{
            //    Console.WriteLine("Üçüncü  ürün fiyatı");
            //    fiyat3 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine($"Ödenecek tutar {((fiyat+fiyat2+fiyat3)*1.20)*0.75} ");
            //}
            //else
            //{
            //    Console.WriteLine($"Ödenecek tutar {(fiyat + fiyat2) * 1.20}");
            //}

            #endregion

            #region Switch Case

            //Console.WriteLine("Birinci ürün fiyatı");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("İkinci ürün fiyatı");
            //double fiyat2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Üçüncü ürünü almak ister misin indirim var? (E/H)");
            //string cevap = Console.ReadLine().ToUpper();
            //double fiyat3;

            //switch (cevap)
            //{
            //    case "E":
            //        Console.WriteLine("Üçüncü  ürün fiyatı");
            //        fiyat3 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine($"Ödenecek tutar {((fiyat + fiyat2 + fiyat3) * 1.20) * 0.75} ");
            //        break;
            //    case "H": Console.WriteLine($"Ödenecek tutar {(fiyat + fiyat2) * 1.20}"); break;
            //    default:
            //        Console.WriteLine("Hatalı seçim");
            //        break;
            //}

            //Console.WriteLine("Renk belirt");
            //string renk = Console.ReadLine().ToLower();
            //switch (renk)
            //{
            //    case "kırmızı": Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("1renk"); break;
            //    case "mavi": Console.ForegroundColor = ConsoleColor.Blue; break;
            //    case "sarı": Console.ForegroundColor = ConsoleColor.Yellow; break;
            //    case "yeşil": Console.ForegroundColor = ConsoleColor.Green; break;
            //    case "gri": Console.ForegroundColor = ConsoleColor.Gray; break;
            //    case "siyah": Console.ForegroundColor = ConsoleColor.Black; break;
            //    case "koyu yeşil": Console.ForegroundColor = ConsoleColor.DarkGreen; break;
            //    case "koyu mavi": Console.ForegroundColor = ConsoleColor.DarkBlue; break;
            //    case "koyu kırmızı": Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("2renk"); goto case "kırmızı";
            //    default: Console.WriteLine("Olmayan renk"); break;

            //}

            #endregion
       
            #region Array ve Methodları
            // string adlar="Erkan","İdil","Batıkan";
            //string ad = "erkan";
            //ad = "Batıkan";
            //string[] adlar = new string[0];
            //adlar[4] = "Erkan";
            //adlar[0] = "Melek";
            //adlar[5] = "Kübra";
            //adlar[1] = "İdil";
            //adlar[2] = "Emin";
            //adlar[3] = "Batıkan";
            //adlar[8] = "Yiğit";
            //adlar[6] = "Süreyya";
            //adlar[7] = "Esma";
            //adlar[9] = "Eren";

            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Resize(ref adlar,adlar.Length+1);
            //adlar[10] = "Tahsin";
            //Console.WriteLine("*************");
            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Array.Resize(ref adlar, adlar.Length + 1);



            //}
            //adlar[4] = "Erkan";
            //adlar[0] = "Melek";
            //adlar[5] = "Kübra";
            //adlar[1] = "İdil";
            //adlar[2] = "Emin";
            //adlar[3] = "Batıkan";
            //adlar[8] = "Yiğit";
            //adlar[6] = "Süreyya";
            //adlar[7] = "Esma";
            //adlar[9] = "Eren";
            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] dizi = new int[0];

            //int i = 0;
            //while (true)
            //{

            //    Console.WriteLine("Kaç sayı eklemek istersin");
            //    int miktar = Convert.ToInt32(Console.ReadLine());
            //    int index = 0;
            //    while (index<miktar)
            //    {
            //        Array.Resize(ref dizi, dizi.Length + 1);
            //        Console.WriteLine($"{i + 1}.Sayıyı giriniz");
            //        dizi[i] = Convert.ToInt32(Console.ReadLine());
            //        i++;
            //        index++;

            //    }
            //    Console.WriteLine("İşlem bitti Eklemek istediğin değer var mı ?");
            //    string cevap = Console.ReadLine().ToLower();
            //    if (cevap == "e")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //foreach (int x in dizi)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region 
            // Baslangic();
            
            #endregion
        }

        //static void Ekle(int[] dizi, int boyut)
        //{
        //    dizi = new int[boyut];
        //    int deger = 0;
        //    while (true)
        //    {
        //        if (dizi.Length == deger)
        //        {
        //            break;
        //        }
        //        Array.Resize(ref dizi, dizi.Length + 1);
        //        Console.WriteLine($"{deger + 1}.Sayıyı giriniz");
        //        dizi[deger] = Convert.ToInt32(Console.ReadLine());

        //        deger++;

        //    }
        //    DiziDondur(dizi);
        //}
        //static void DiziDondur(int[] dizi)
        //{
        //    foreach (var item in dizi)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        
        static void Baslangic()
        {
           
            Thread.Sleep(1000);
            Console.WriteLine("Mutfağa git");
            Thread.Sleep(2000);
            Console.WriteLine("Evde Çay su var mı ?");
            string cevap = Console.ReadLine().ToLower();
            if (cevap == "e")
            {
                Console.WriteLine("Çaydanlığa su koy");
                Thread.Sleep(2000);
                Console.WriteLine("Ocağı aç");
                Thread.Sleep(2000);
                Console.WriteLine("Çaydanlığı ocağa koy");
                Thread.Sleep(2000);
                Console.WriteLine("Çay su kaynadı mı ?");
            }
            else if (cevap == "h")
            {
                Market();
            }

        }
        static void Market()
        {
            while (true)
            {
                Console.WriteLine("Market açık mı ?");
                string cevap = Console.ReadLine();
                if (cevap == "e")
                {
                    Console.WriteLine("Eksikleri al");
                    Thread.Sleep(2000);
                    Console.WriteLine("Eve dön");
                    Baslangic();
                    break;
                }
                else if (cevap == "h")
                {
                    Console.WriteLine("Başka markete git");

                    Thread.Sleep(2000);
                }
               
            }
           

        }
    }
}
