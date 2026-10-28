namespace _21_List_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Kisi kisi = new Kisi();//Nesne oluşturma
            kisi.Ad = "Erkan";
            kisi.Soyad = "Türk";
            kisi.Yas = 32;
            kisi.DogumTarihi = Convert.ToDateTime("01.01.1907");

            Kisi kisi2 = new Kisi();//Nesne oluşturma
            kisi2.Ad = "Tahsin";
            kisi2.Soyad = "Canpolat";
            kisi2.Yas = 35;
            kisi2.DogumTarihi = Convert.ToDateTime("01.01.1905");

            Kisi kisi3 = new Kisi();//Nesne oluşturma
            kisi3.Ad = "Altan Emre";
            kisi3.Soyad = "Demirci";
            kisi3.Yas = 37;
            kisi3.DogumTarihi = Convert.ToDateTime("15.12.1907");

            //List<string> list = new List<string>();
            //list.Add(kisi.Ad);
            //list.Add(kisi.Soyad);
            //list.Add(kisi2.Ad);
            //list.Add(kisi2.Soyad);
            //list.Add(kisi3.Ad);
            //list.Add(kisi3.Soyad);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(kisi);
            kisiler.Add(kisi2);
            kisiler.Add(kisi3);
            kisi3.Yas = 18;
            foreach (var item in kisiler)
            {
                Console.WriteLine($"AdSoyad{item.Ad + " " + item.Soyad}\nYaş{item.Yas}\nDoğum Tarihi{item.DogumTarihi}");
            }
            //List<Kisi> kisis = new List<Kisi>()
            //{
            //    new Kisi(){Ad="Erkan",Soyad="Türk",Yas=32,DogumTarihi=DateTime.Now},
            //    new Kisi(){Ad="Erkan1",Soyad="Türk",Yas=32,DogumTarihi=DateTime.Now},
            //    new Kisi(){Ad="Erkan2",Soyad="Türk",Yas=32,DogumTarihi=DateTime.Now},
            //    new Kisi(){Ad="Erkan3",Soyad="Türk",Yas=32,DogumTarihi=DateTime.Now}
            ////};
            //foreach (var item in kisis)
            //{
            //    Console.WriteLine($"AdSoyad{item.Ad+" "+item.Soyad}\nYaş{item.Yas}\nDoğum Tarihi{item.DogumTarihi}");
            //}

            Console.WriteLine(kisi3.Ad);

        }
    }
    class Kisi //Sınıf yapısı
    {
        //Property sınıfın özelliğidir kişi sınıfının niteliği
        public string Ad { get; set; }//Get getirmek Set değer eklemek güncellemek
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public DateTime DogumTarihi {  get; set; }

    }
}
