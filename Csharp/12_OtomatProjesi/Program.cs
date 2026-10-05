namespace _12_OtomatProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region proje
            /* 
            5 elemanlı bir ürünler dizisi olsun 
          Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
         Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği
         ile tekrar para girmesi sağlanacak. eğer para fazla ise üstü verilecek.
         satın alma tamamlandıktan sonra başka bir isteğiniz var mı diye sorulacak
            var ise tekrardan ürünler listesine geçilecek yok ise program sonlanacak.

          // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de var ise eklenmeyecek yok ise eklenecek
            Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir uyarısı veririp açıldığında bilgilendirecek
          */
            #endregion

            #region OtomatProjesi
            bool admin = false;
            string pass = "123";
            string adminPass;
            int hak = 0;
            bool hesapKilit = false;
            string[] urunler = { "kola", "fanta", "sprite", "ayran", "cips" };
            double[] fiyatlar = { 80, 70, 70, 50, 100 };
            double bakiye = 0;
            //-1 olmayan index değeridir.
            while (true)
            {
                try
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                    }
                    Console.WriteLine("Ürün numarası giriniz (Admin girişi için -1 e basınız)");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    if (urunNo == -1)
                    {
                        Console.Clear();
                        if (!hesapKilit)
                        {
                            while (hak < 3)
                            {
                                Console.WriteLine("Admin Şifreniz.");
                                adminPass = Console.ReadLine();
                                if (adminPass == pass)
                                {
                                    admin = true;
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    hak++;
                                    Console.WriteLine("Yanlış şifre kalan hakkınız:" + (3 - hak));
                                }
                                if (hak == 3)
                                {
                                    Console.WriteLine("Çok sayıda hatalı işlem yapıldı sistem 10 saniye kitlendi");
                                    hesapKilit = true;
                                    for (int i = 10; i >= 0; i--)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Lütfen bekleyin:" + i);
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                    Console.ResetColor();
                                    hesapKilit = false;
                                    hak = 0;
                                    continue;
                                }

                            }
                            Console.Clear();
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Hesap kilitli,");
                            hesapKilit = true;
                            for (int i = 10; i >= 0; i--)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Lütfen bekleyin:" + i);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.ResetColor();
                            hesapKilit = false;
                            hak = 0;
                        }
                        continue;
                    }
                    Console.WriteLine("Para girişi yapınız");
                    bakiye = Convert.ToDouble(Console.ReadLine());
                    if (bakiye >= fiyatlar[urunNo])
                    {
                        Console.WriteLine("Ürünü aldınız.\nAfiyet olsun\nPara Üstü:" + (bakiye - fiyatlar[urunNo]));
                        Thread.Sleep(2000);
                        bakiye = 0;
                        Console.Clear();
                        
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz Bakiye");
                            Console.WriteLine("1-Para Ekle\n2-Para İade");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("Para Ekle");
                                bakiye += Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= fiyatlar[urunNo])
                                {
                                    Console.WriteLine("Ürünü aldınız.\nAfiyet olsun\nPara Üstü:" + (bakiye - fiyatlar[urunNo]));
                                    Thread.Sleep(2000);
                                    bakiye = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim==2)
                            {
                                Console.WriteLine("Para İade Edildi:"+bakiye);
                                bakiye = 0;
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata:{ex.Message}");
                    Thread.Sleep(2000);
                }
            }
            if (admin)
            {
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Admin Paneline Hoşgeldiniz\nYapmak istediğiniz işlemi belirtiniz....");
                        Console.WriteLine("1-Ürün Ekle\n2-Güncelle\n3-Sil\n4-Listele\n5-Çıkış");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAdi = Console.ReadLine().ToLower();

                            bool kontrol = false;
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                if (urunler[i] == urunAdi)
                                {
                                    kontrol = true;
                                    break;
                                }

                            }
                            //if (urunler.Contains(urunAdi))
                            //{
                            //    kontrol = true;
                            //    break;
                            //}
                            if (kontrol)
                            {
                                Console.WriteLine("Ürün zaten mevcut");
                                Thread.Sleep(2000);
                                continue;
                            }
                            Console.WriteLine("Ürün Fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());
                            Array.Resize(ref urunler, urunler.Length + 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                            urunler[urunler.Length - 1] = urunAdi;
                            fiyatlar[fiyatlar.Length - 1] = fiyat;
                        }
                        else if (secim == 2)
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                            }
                            Console.WriteLine("Güncellenecek ürün:");
                            string guncelle = Console.ReadLine().ToLower();
                            int index;
                            if (int.TryParse(guncelle, out index))
                            {
                                if (index >= 0 && index < urunler.Length)
                                {
                                    Console.WriteLine("Yeni ürün adı:");
                                    string yeniUrun = Console.ReadLine().ToLower();
                                    Console.WriteLine("Yeni ürün fiyatı");
                                    double yenifiyat = Convert.ToDouble(Console.ReadLine());
                                    urunler[index] = yeniUrun;
                                    fiyatlar[index] = yenifiyat;
                                    Console.WriteLine("Ürün Güncellendi");
                                    Thread.Sleep(2000);

                                }
                            }
                            else
                            {
                                int i = Array.IndexOf(urunler, guncelle);
                                if (i >= 0 && i < urunler.Length)
                                {
                                    Console.WriteLine("Yeni ürün adı:");
                                    string yeniUrun = Console.ReadLine().ToLower();
                                    Console.WriteLine("Yeni ürün fiyatı");
                                    double yenifiyat = Convert.ToDouble(Console.ReadLine());
                                    urunler[i] = yeniUrun;
                                    fiyatlar[i] = yenifiyat;
                                    Console.WriteLine("Ürün Güncellendi");
                                    Thread.Sleep(2000);

                                }
                            }

                        }
                        else if (secim == 3)
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                            }
                            Console.WriteLine("Silmek istediğiniz ürün numarası:");
                            int silinecekNo = Convert.ToInt32(Console.ReadLine());
                            if (silinecekNo >= 0 && silinecekNo < urunler.Length)
                            {
                                for (int i = silinecekNo; i < urunler.Length - 1; i++)
                                {
                                    urunler[i] = urunler[i + 1];
                                    fiyatlar[i] = fiyatlar[i + 1];
                                }
                                Array.Resize(ref urunler, urunler.Length - 1);
                                Array.Resize(ref fiyatlar, fiyatlar.Length - 1);
                                Console.WriteLine("Ürün Silindi");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı işlem");
                                Thread.Sleep(2000);
                            }
                        }
                        else if (secim == 4)
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}.{urunler[i]}-{fiyatlar[i]}");
                            }
                            Thread.Sleep(4000);
                        }
                        else if (secim == 5)
                        {
                            Console.WriteLine("İyi günler");
                            admin = false;
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                            Thread.Sleep(2000);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata:" + ex.Message);
                         Thread.Sleep(2000);
                    }
                    finally//Her koşulda finally çalışır.
                    {
                        Console.WriteLine("sistem çalışmaya devam eder.");
                        Thread.Sleep(2000);
                    }

                }
            }
            #endregion

        }
    }
}
