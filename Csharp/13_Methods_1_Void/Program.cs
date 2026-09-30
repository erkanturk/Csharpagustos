namespace _13_Methods_1_Void
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Method Tanım
            /*Methods-Function
             * Methodlar yazılımcılar tarafından geliştirilen ve diğer yazılımcıların kullanımına sunulan hazır kod yapılarıdır.
             * Methodlara bir isim verilir ve o isim altında bir iş yapan kod bloğu yazılır.
             * Yazılımcı o işi yapmak için methodu çağırması yeterlidir.
             * Bu sayede yazılımcı tanımlı işin kodunu tekrar tekrar yazmak yerine method yapısını çağırarak kullanır.
             * 
             * Methodlar ve  Functionlar () ile tanımlanır.
             * Method içerisinde method yazılamaz ama Method içerisinde method çağırabiliriz.
             * Methodlar çağırılmadığı sürecede çalışmazlar
             * Method isimleri benzersiz (Unique) olmalıdır.Aynı isime sahip method yapılarının
             * İmza yapısı farklı olmalıdır.(int , string , bool , char vb) bu yapılar methodun imzasıdır.
             * Methodlar hazır yapılardır fonksiyonlar ise yazılımcının yazdığı method yapısıdır.
             * Methodlar 2 ye ayrılır.
             * Geriye değer döndüren method(Parametreli/Parametresiz)
             * İş yapan method (Parametreli/Parametresiz)
             * 
             * MyMethod();
             * Method isimleri genelde PascalCase olarak yazılır.
             * 
            */
            #endregion
            #region Örnekler
            //Yaz();
            //IsimYaz("Erkan");
            //string soyisim = "Türk";
            //IsimYaz(soyisim);
            #endregion
            #region Örnek2
            //Kaydet();
            //Kaydet();//Methodlar çağırıldığı kadar çalışır.
            //Kaydet();
            //Kaydet();
            //Kaydet();
            //Kaydet();
            //Kaydet();
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaş");
            double maas = Convert.ToDouble(Console.ReadLine());

            Kaydet2(ad,soyad,yas,maas);
            #endregion
        }
        static void Yaz()//Bir methodda void keywordü var ise bu method iş yapan method yapıdır.
        {// Parametresiz method.
            Console.WriteLine("Merhaba Method");
        }

        static void IsimYaz(string isim)//Parametreli method
        {//Parametre yapısı ihtiyaca göre değeri artıp azalabilir yazılımcının tanımlamasına bağlıdır
            //Her veri tipi parametre olarak kullanıla bilir bu değerlere variables ve collections class gibi yapılarda 
            //Dahildir.
            Console.WriteLine(isim);
        }
        static void Kaydet()
        {
            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyad= Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaş");
            double maas= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ad:{ad} Soyad:{soyad} Yaş:{yas} Maaş:{maas}");
        }
        static void Kaydet2(string ad,string syad,int age,double maas)
        {
            Console.WriteLine($"Ad:{ad} Soyad:{syad} Yaş:{age} Maaş:{maas}");
        }


    }
}
