using System.Collections;

namespace _16_ManavOtomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ManavOtomasyonu
            /*
            HAL - Toptancı
           * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
           * 5 adet meyve listelenecek
           * Meyve seçildikten sonra "Kaç Kilo?"
           * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
           * 
           * 
            MANAV
           * "Meyve mi Sebze mi?" diye müşteriye soracağız.
           * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
           * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
           * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
           * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
           * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
           * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
           * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

           MÜŞTERİ
           * Alınan ürünleri ekrana yazdırınız.
            */
            #endregion

            ArrayList halMeyveler = new ArrayList() { "elma", "armut", "muz", "çilek", "karpuz" };
            ArrayList halSebzeler = new ArrayList() { "domates", "biber", "patlıcan", "patates", "soğan" };
            ArrayList manavMeyveler = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebzeler = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();
            bool deger = true;
            Console.WriteLine("Uby Hale Hoşgeldiniz");
            while (deger)
            {
                Console.WriteLine("Meyve mi Sebze mi ? (M/S) Çıkış için Q ya basın.");
                string halSecim = Console.ReadLine().ToLower();
                if (halSecim == "m")
                {
                    try
                    {
                        Console.WriteLine("1-Elma\n2-Armut\n3-Muz\n4-Çilek\n5-Karpuz");
                        string meyve = Console.ReadLine().ToLower();
                        int meyve2;
                        if (int.TryParse(meyve, out meyve2))
                        {
                            if (meyve2 == 1)
                            {
                                UrunAl(manavMeyveler, "elma", manavMeyveKilo);
                            }
                            else if (meyve2 == 2)
                            {
                                UrunAl(manavMeyveler, "armut", manavMeyveKilo);
                            }
                            else if (meyve2 == 3)
                            {
                                UrunAl(manavMeyveler, "muz", manavMeyveKilo);
                            }
                            else if (meyve2 == 4)
                            {
                                UrunAl(manavMeyveler, "çilek", manavMeyveKilo);
                            }
                            else if (meyve2 == 5)
                            {
                                UrunAl(manavMeyveler, "karpuz", manavMeyveKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            if (meyve == "elma")
                            {
                                UrunAl(manavMeyveler, "elma", manavMeyveKilo);
                            }
                            else if (meyve == "armut")
                            {
                                UrunAl(manavMeyveler, "armut", manavMeyveKilo);
                            }
                            else if (meyve == "muz")
                            {
                                UrunAl(manavMeyveler, "muz", manavMeyveKilo);
                            }
                            else if (meyve == "çilek")
                            {
                                UrunAl(manavMeyveler, "çilek", manavMeyveKilo);
                            }
                            else if (meyve == "karpuz")
                            {
                                UrunAl(manavMeyveler, "karpuz", manavMeyveKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        Console.Clear();
                        deger = Devam();
                        if (deger)
                        {
                            continue;
                        }
                        else
                        {
                            deger = true;
                            break;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("hata:" + ex.Message);
                    }
                }
                else if (halSecim == "s")
                {
                    try
                    {
                        Console.WriteLine("1-Domates\n2-Biber\n3-Patlıcan\n4-Patates\n5-Soğan");
                        string sebze = Console.ReadLine().ToLower();
                        int sebze2;
                        if (int.TryParse(sebze, out sebze2))
                        {
                            if (sebze2 == 1)
                            {
                                UrunAl(manavSebzeler, "domates", manavSebzeKilo);
                            }
                            else if (sebze2 == 2)
                            {
                                UrunAl(manavSebzeler, "biber", manavSebzeKilo);
                            }
                            else if (sebze2 == 3)
                            {
                                UrunAl(manavSebzeler, "patlıcan", manavSebzeKilo);
                            }
                            else if (sebze2 == 4)
                            {
                                UrunAl(manavSebzeler, "patates", manavSebzeKilo);
                            }
                            else if (sebze2 == 5)
                            {
                                UrunAl(manavSebzeler, "soğan", manavSebzeKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            if (sebze == "domates")
                            {
                                UrunAl(manavSebzeler, "domates", manavSebzeKilo);
                            }
                            else if (sebze == "biber")
                            {
                                UrunAl(manavSebzeler, "biber", manavSebzeKilo);
                            }
                            else if (sebze == "patlıcan")
                            {
                                UrunAl(manavSebzeler, "patlıcan", manavSebzeKilo);
                            }
                            else if (sebze == "patates")
                            {
                                UrunAl(manavSebzeler, "patates", manavSebzeKilo);
                            }
                            else if (sebze == "soğan")
                            {
                                UrunAl(manavSebzeler, "soğan", manavSebzeKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        Console.Clear();
                        deger = Devam();
                        if (deger)
                        {
                            continue;
                        }
                        else
                        {
                            deger = true;
                            break;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("hata:" + ex.Message);
                    }
                }
                else if (halSecim == "q")
                {
                    Console.WriteLine("İyi günler");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");
                    Thread.Sleep(2000);
                }
            }
            while (deger)
            {
                Console.WriteLine("Uby Manava hoşgeldiniz");
                Console.WriteLine("Meyve mi Sebze mi ? (M/S) Çıkış için Q");
                string manavSecim = Console.ReadLine().ToLower();
                if (manavSecim == "m")
                {
                    if (manavMeyveler.Count == 0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir");
                        Thread.Sleep(2000);
                        continue;
                    }
                    Dondur(manavMeyveler, manavMeyveKilo);
                    try
                    {
                        Console.WriteLine("Ürün adı veya numarası");
                        string input = Console.ReadLine().ToLower();
                        int meyveNo;
                        string meyve = "";
                        if (int.TryParse(input, out meyveNo))
                        {
                            if (meyveNo >= 1 && meyveNo <= manavMeyveler.Count)
                            {
                                meyve = manavMeyveler[meyveNo - 1].ToString();

                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                                continue;
                            }
                        }
                        else
                        {
                            meyve = input;
                            if (!manavMeyveler.Contains(meyve))
                            {
                                Console.WriteLine("Olmayan ürün");
                                Thread.Sleep(2000);
                            }
                        }
                        if (manavMeyveler.Contains(meyve))
                        {
                            Console.WriteLine("Kaç Kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavMeyveler.IndexOf(meyve);
                            int meyveKilo = (int)manavMeyveKilo[index];
                            if (meyveKilo >= kilo)
                            {
                                meyveKilo -= kilo;
                                musteri.Add($"{meyve}=>{kilo} kilo");
                                manavMeyveKilo[index] = meyveKilo;
                                if (meyveKilo == 0)
                                {
                                    manavMeyveler.RemoveAt(index);
                                    manavMeyveKilo.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı {meyve} için kalan stok {meyveKilo} kilo");
                                Thread.Sleep(2000);

                            }
                            else
                            {
                                Console.WriteLine($"İstenen kilo mevcut değil {meyve} => {meyveKilo} kilo mevcut");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün");
                            Thread.Sleep(2000);
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata:" + ex.Message);
                    }
                    Console.Clear();
                    deger = Devam();
                    if (deger)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else if (manavSecim == "s")
                {
                    if (manavSebzeler.Count == 0)
                    {
                        Console.WriteLine("Sebzeler tükenmiştir");
                        Thread.Sleep(2000);
                        continue;
                    }
                    Dondur(manavSebzeler, manavSebzeKilo);
                    try
                    {
                        Console.WriteLine("Ürün Seçiniz");
                        string input = Console.ReadLine().ToLower();
                        string sebze = "";
                        if (int.TryParse(input, out int sebzeNo))
                        {
                            if (sebzeNo >= 1 && sebzeNo <= manavSebzeler.Count)
                            {
                                sebze = manavSebzeler[sebzeNo - 1].ToString();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                                continue;
                            }
                        }
                        else
                        {
                            sebze = input;
                            if (!manavSebzeler.Contains(sebze))
                            {
                                Console.WriteLine("Olmayan ürün");
                                Thread.Sleep(2000);
                                continue;
                            }
                        }
                        if (manavSebzeler.Contains(sebze))
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavSebzeler.IndexOf(sebze);
                            int sebzeKilo = (int)manavSebzeKilo[index];
                            if (sebzeKilo >= kilo)
                            {
                                sebzeKilo -= kilo;
                                musteri.Add($"{sebze}=>{kilo}");
                                manavSebzeKilo[index] = sebzeKilo;
                                if (sebzeKilo == 0)
                                {
                                    manavSebzeKilo.RemoveAt(index);
                                    manavSebzeler.RemoveAt(index);
                                }
                                Console.WriteLine($"Satış başarılı {sebze} için kalan stok:{sebzeKilo} kilo");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine($"istenen {sebze} =>{sebzeKilo} kilo mevcut");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("olmayan ürün");
                            Thread.Sleep(2000);
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Hata:" + e.Message);
                    }
                    Console.Clear();
                    deger = Devam();
                    if (deger)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (manavSecim == "q")
                {
                    Console.WriteLine("İyi günler");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim");
                    Thread.Sleep(2000);
                    continue;
                }

            }
            foreach (var m in musteri)
            {
                Console.WriteLine($"Alınan ürünler {m}");
            }
        }
        static void Dondur(ArrayList urunList,ArrayList kiloList)
        {
            for (int i = 0; i < urunList.Count; i++)
            {
                Console.WriteLine($"{i + 1}-{urunList[i]}-{kiloList[i]} kilo mevcut");
            }
        }
        static void UrunAl(ArrayList urunList, string urunAdi, ArrayList kiloList)
        {
            if (urunList.Contains(urunAdi) == false)
            {
                urunList.Add(urunAdi);
                Console.WriteLine("Kaç Kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                kiloList.Add(kilo);

            }
            else
            {
                Console.WriteLine("Kaç Kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                int index = urunList.IndexOf(urunAdi);
                int meyveKilo = (int)kiloList[index]!;//! bu alanın null olmayacağını garanti eder sonda olursa
                meyveKilo += kilo;
                kiloList[index] = meyveKilo;
            }
        }
        static bool Devam()
        {
            Console.WriteLine("Başka bir  arzunun var mı ? (E/H)");
            string cevap = Console.ReadLine().ToLower().Trim();
            if (cevap == "e")
            {
                return true;
            }
            else if (cevap == "h")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Hatalı seçim");
                Console.WriteLine();
                for (int i = 5; i >=0; i--)
                {
                    Console.WriteLine(i+ " Anasayfaya yönlendiriliyorsunuz.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                return true;
            }
        }
    }
}
