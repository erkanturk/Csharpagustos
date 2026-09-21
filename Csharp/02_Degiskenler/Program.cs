namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programlama dilleri büyük küçük harfe duyarlı yapılardır Örneğin A değeri ile a 
             * değeri birbirine eşit değildir
             * Programlama dillerinde dışarıdan gelen her değer metinsel olarak kabul edilir " " bu tırkan içi metinsel olur.
             * C# dili Data protected bir dil yapısıdır 
             * Değişken isimleri benzersiz olmalıdır aynı tanımı 1 den fazla yapamayız.
             */
            Console.WriteLine("Erkan Türk");

            //Metinsel veri tipi
            // string x =10;//MEtinsel bir veri tipi içerisine sayısal değer koyamayız
            // x = "Türk";//veya sayısal veri tipine metinsel değer koyamayız
            // Console.WriteLine("10"+10);metinsel bir değer sayısal bir değerle toplanamaz.
            string ad = "Erkan";
            string soyad = "Türk";
            Console.WriteLine(ad + soyad);
            //string yapı birbiri ile birleştirilimiş char karakterlerdir.
            //Tek harf
            char harf = 'A';//char yapısı tek tırnakla tanımlanır 1 karakter alır.
                            //Console.WriteLine(harf);
                            //Console.WriteLine((int)harf);
                            //Console.WriteLine((char)126);
                            //https://www.ascii-code.com/

            //mantıksal veri tipi
            bool mantiksal = true;//1 
            bool mantiksal2 = false;//0
            Console.WriteLine(mantiksal);
            Console.WriteLine(mantiksal2);

            //Sayısal veri tipleri 

            //Tam sayılar
            byte enKucuk = 255;//En küçük tam sayı veri tipi
            int ortaTam = 1234567890;//Genelde en sık kullanıkan tam sayı tipi
            long enBuyukTamSayi = 123456789123456;//En büyük tam sayi
            short ortaBuyukluk = 32747;
            //Ondalıklı sayılar
            float enKucukOndalik = 123.456f;
            double ondalikli = 1234.5647;
            decimal enBuyukOndalikli = 123456.7987m;//tüm sayısal veri tipleri value type olarak geçer stack 

            Console.WriteLine($"byte maks:{byte.MaxValue} min:{byte.MinValue}");
            Console.WriteLine($"int maks:{int.MaxValue} min:{int.MinValue}");
            Console.WriteLine($"long maks:{long.MaxValue} min:{long.MinValue}");
            Console.WriteLine($"float maks:{float.MaxValue} min:{float.MinValue}");
            Console.WriteLine($"double maks:{double.MaxValue} min:{double.MinValue}");
            Console.WriteLine($"decimal maks:{decimal.MaxValue} min:{decimal.MinValue}");
            Console.WriteLine($"short maks:{short.MaxValue} min:{short.MinValue}");
            //referans type 
            object nesne = "Metin";//heap
            object nesne2 = 123;//boxing
            object nesne3 = 'A';
            object nesne4 = true;

            int sayi = (int)nesne2;//unboxing
            Console.WriteLine(sayi);
            var veri = 123;
            var veri2 = "string";
            var veri3 = true;
            var veri4 = 'a';

            //Tarih zaman veri tipi
            DateTime time = DateTime.Now;//Şimdiki zaman
            Console.WriteLine(time);
            Console.WriteLine(time.Year);
            Console.WriteLine(time.Month);
            Console.WriteLine(time.Day);
            Console.WriteLine(time.Hour);
            Console.WriteLine(time.Minute);
            Console.WriteLine(time.Second);
            Console.WriteLine(time.Microsecond);

            sayi = 321;//güncelleme işlemi
            Console.WriteLine(sayi);

            //değişken tanımlayıp bu değişkenleri Console.WriteLine içerisinde çağırıp kullanacağız
            //Bu yapıda Ad Soyad Yaş Char Olarak Cinsiyet bilgisi Double olarak maaş bilgisi yazsın


            string isim = "Erkan";
            string soyisim = "Türk";
            int yas = 32;
            char cinsiyet = 'E';
            double maas = 4500;
            Console.WriteLine($"İsim:{isim}\nSoyisim:{soyisim}\nYaş:{yas}\nMaaş:{maas}\nCinsiyet:{cinsiyet}");
            //\n bir alt satıra yazdırır enter görevi görür.
            //$ string interpolation {} parantezler içerisinde csharp yapısını kullanabiliriz.

            //Const bir veri yapısını değiştirilemez sabit bir yapıda kullanmak için const ifadesini kullanırız.

            //double pi = 3.14;
            //Console.WriteLine(pi);
            //pi = 4;
            //Console.WriteLine(pi);
            //const double  pi = 3.14;//bu değer değiştirilemez
            //Console.WriteLine(pi);
            //pi = 4;//Hata verir çünkü const ile sabitlenmiştir.
            //Console.WriteLine(pi);


        }
    }
}
