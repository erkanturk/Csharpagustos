namespace _28_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Partial Class
            * Parçalı sınıf giziksel olarak Personel ve Personel1 adında oluşturulan 2 farklı sının 
            * aynı çatı altında çalışmasını sağlayan yapıdır
            * Her iki classa da partial keywordü veririz sistem projeyi derlerken bu sınıfların tek bir yapı olarak
            * Hareket etmesini sağlar
            * Çok büyük projelerde kod karmaşasını engellemek için kullanılır iki yapıda tek nesne üzerinden kontrol edilir.
            * Ve overload işlemlerinide yapabiliriz
            * 
            */

            Personel personel = new Personel();
            personel.AdSoyad = "Erkan Türk";
            personel.Adres = "Kadıköy";
            personel.Email = "test@test.com";
            personel.Yazdir();
        }
    }
}
