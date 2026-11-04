namespace _24_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Constructor 
             * Sınıf yapınısının arka planında çalışan özel bir metottur.
             * Bu method yapısı sınıfın bir nesnesi oluşturulduğunda otomatik olarak çalışır.
             * Ve bu yapı sınıfı kullanıma hazır hale getirir.(Sınıfı ayağa kaldırır)
             * Constructor yapısı sınıf ile aynı isme sahiptir ve geri dönüş tipi yoktur.
             * Return void int vb değerleri alamaz. Parametre alabilir. Overload edilebilir.
             * Dışa bağımlılık için constructor yapısı kullanılır. Dependency Injection
             * Bu yapı Garbage Collector tarafından yönetilir. 
             * Yani nesne oluşturulduğunda bellekte yer açılır ve 
             * nesne işimiz bittiğinde Garbage Collector tarafından bellekten silinir.
             * C++ C dillerinde destructor yapısı manuel kullanılır
             * C# dilinde ise Garbage Collector tarafından yönetilir.
             * Disposeable pattern yapısı ile nesne bellekten silinirken yapılacak işlemler tanımlanabilir.
             * IDisposable interface yapısı ile nesne bellekten silinirken yapılacak işlemler tanımlanabilir.
             * C# dilinde bu yapıyı using ile kullanırız ve otomatik olarak bellekten silinir.
             * Bellekten silme işlemi En kolay tanımlanan yada En eski az kullanılan yapıyı otomatik olarak siler.
             * 
             */
            Customer customer = new Customer("Erkan", "Türk", 25);
            Customer customer1 = new Customer();
            customer.Kaydet();
        }
    }
    class Customer
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public void Kaydet()
        {
            Console.WriteLine("Ad");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            Soyad = Console.ReadLine();
            Console.WriteLine("Yas");
            Yas = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Ad} {Soyad} {Yas}");

        }
        public Customer(string ad, string soyad, int yas)//DI Dependency Injection yapısı ile dışa bağımlılık tanımlanabilir. 
        {
            Ad = ad;//Sınıfın nesnesi oluşturulurken bu değerler mutlaka alınsın diye constructor yapısı kullanılır.
            Soyad = soyad;
            Yas = yas;
            Console.WriteLine($"{Ad} {Soyad} {Yas}");
        }

        public Customer()//Ctor diyerek de çağırabiliriz Constructor yapısını
        {

        }
    }
}
