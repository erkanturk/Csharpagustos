namespace _27_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Inheritance(Kalıtım/Miras alma)
             * Bir sınıf ortak özellikleri barındırır.
             * Bu sınıf yapısı parrent sınıf olarak oluşturulur ve bu sınıftan miras alan child sınıflar
             * Parrent sınıfın özelliklerini kullanabilirler.
             * Bu yapıyı kullanmak için ':' iki nokta işlemi ile sınıfın kalıtım alması gerekmektedir
             * fakat bu yapı sealed olarak işaretlenmi ise kalıtım almaya uygun değildir
             * !!!Önemli not
             * Parrent sınıf child sınıftan miras almaz veya child sınıfın özelliklerini kullanmaz.
            */

            IK ik = new IK();
            ik.Tc = "123123123";
            ik.AdSoyad = "Erkan türk";
            ik.Adres = "Kadıköy Caferağa";
            ik.IseGirisTarihi = DateTime.Now;
            ik.PersonelSayisi = 50;
            ik.Yas = 26;
            ik.SigortaNo = "12345";
            ik.PersonelBilgileri();

            Console.WriteLine("*******");
            Muhasebe muh = new Muhasebe();
            muh.Tc = "123123123";
            muh.AdSoyad = "Erkan türk";
            muh.Adres = "Kadıköy Caferağa";
            muh.IseGirisTarihi = DateTime.Now;
            muh.HesapSayisi = "50";
            muh.Yas = 26;
            muh.SigortaNo = "12345";
            muh.PersonelBilgileri();
            Console.WriteLine("*******");
            Pazarlama paz = new Pazarlama();
            paz.Tc = "123123123";
            paz.AdSoyad = "Erkan türk";
            paz.Adres = "Kadıköy Caferağa";
            paz.IseGirisTarihi = DateTime.Now;
            paz.MusteriSayisi = 50;
            paz.Yas = 26;
            paz.SigortaNo = "12345";
            paz.PersonelBilgileri();

         


        }

    }
}
