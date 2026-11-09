namespace _25_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP
            /* Object Oriented Programming (Nesne yönelimli programlama) OOP
             * OOP Yapısı 4 Temel prensipten oluşur 
             * Bu prensiplerden ilki 
             * 
             * 1.Encapsulation (Kapsülleme) prensibidir.
             * Encapsulation yapısı verinin güvenli bir şekilde taşınmasını sağlar.
             * Bu yapı aslında güvenlik görevlisi gibi düşünebiliriz
             * Veri eğer şartlarıma uyuyorsa bu veriyi içeriye alırım 
             * Eğer uymuyorsa bu veri içeriye giremez
             * Encapsulation yapısında tanımlanan propertyler private olarak tanımlanır yani sınıfa açık
             * Dışarıya kapalı 
             * Dışarıdan gelen yapılar public olarak _ ile tanımlanan farklı yapılardan 
             * Güvenlik kontrolünden geçerek içeriye alınır.
             * 
             * 2.Prensip Inheritance (Kalıtım) prensibidir.
             * Parrent sınıf yapısının child sınıflara miras vermesi yani 
             * Ortak olarak tanımlanan özellikleri child sınıfların kullanmasını ve 
             * Aynı yapıların tekrar tekran tanımlanmasını engelleyen prensiptir.
             * Not Child sınıflar miras alıp değerleri kullanır fakat Parrent sınıf  child sınıfın özelliklerini kullanamaz.
             * 
             * 3.Polymorphism (Çok Biçimlilik) prensibidir.
             * Aynı sınıf yapısında bulunan methodların farklı davranışlar sergilemesini sağlayan prensiptir.
             * 
             * 
             * 4.Abstraction (Soyutlama) prensibidir.
             * Soyut yapıların somutlaştırılması ve parrent child ilişkisi ile ortak yapıların kullanılması prensibidir.
             */
            #endregion
            #region Örnek1
            Vatandas vatandas = new Vatandas();
            Console.WriteLine("Ad Soyad");
            vatandas.AdSoyad = Console.ReadLine();
            Console.WriteLine("Tc No");
            vatandas._TcNo = Console.ReadLine();

            Console.WriteLine(vatandas.AdSoyad);



            #endregion
        }
    }
}
