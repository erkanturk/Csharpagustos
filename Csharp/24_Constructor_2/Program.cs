namespace _24_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            foreach (var item in ogrenci.OgrenciListele())
            {
                Console.WriteLine(item.Adi + " " + item.Soyadi + " " + item.DogumYili);
            }

            Ogrenci ogrenci1 = new Ogrenci(1, "Test", "test", 1234);
            Ogrenci ogrenci2 = new Ogrenci(1, "Test2", "test", 1234);
            Ogrenci ogrenci3 = new Ogrenci(1, "Test3", "test", 1234);
            Ogrenci ogrenci4 = new Ogrenci(1, "Test4", "test", 1234);
            Ogrenci ogrenci5 = new Ogrenci(1, "Test5", "test", 1234);
            Ogrenci ogrenci6 = new Ogrenci(1, "Test6", "test", 1234);
            Ogrenci ogrenci7 = new Ogrenci(1, "Test7", "test", 1234);
            Ogrenci ogrenci8 = new Ogrenci(1, "Test8", "test", 1234);

            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(ogrenci1);
            ogrencis.Add(ogrenci2);
            ogrencis.Add(ogrenci3);
            ogrencis.Add(ogrenci4);
            ogrencis.Add(ogrenci5);
            ogrencis.Add(ogrenci6);
            ogrencis.Add(ogrenci7);
            ogrencis.Add(ogrenci8);
            foreach (var item in ogrencis)
            {
                Console.WriteLine(item.OgrNo+" "+item.Adi+" "+item.Soyadi+" "+item.DogumYili);
            }

        }
    }
}
