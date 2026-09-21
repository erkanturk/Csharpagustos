namespace _08_Switch_Case_2_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            /*
           kullanıcıdan alınan cinsiyet bilgisine göre
        ==> ERKEK ise
           yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
          ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
          6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
            yaşı 56 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
          yaş 56'ın altında ise çalıştığı gün sayısına göre eğer 5000 ve üstü ise 
          maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5000 
          altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */
            #endregion

            Console.WriteLine("Cinsiyet");
            string cinsiyet = Console.ReadLine().ToUpper();
            switch (cinsiyet)
            {
                case "ERKEK":
                    Console.WriteLine("Yaşınız");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if(yas>=60)
                    {
                        Console.WriteLine("Maaşınız");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Emeklilik ikramiyeniz:{maas*10}");
                    }
                    else
                    {
                        Console.WriteLine("Prim Gün Sayısı");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaşınız");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Emeklilik ikramiyeniz:{maas * 11}");
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik yalan oldu...");
                        }
                    }
                    break;
                case "KADIN":
                    Console.WriteLine("Yaşınız");
                    int yas2 = Convert.ToInt32(Console.ReadLine());
                    if (yas2 >= 56)
                    {
                        Console.WriteLine("Maaşınız");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Emeklilik ikramiyeniz:{maas * 10}");
                    }
                    else
                    {
                        Console.WriteLine("Prim Gün Sayısı");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim >= 5000)
                        {
                            Console.WriteLine("Maaşınız");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Emeklilik ikramiyeniz:{maas * 11}");
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik yalan oldu...");
                        }
                    }
                    break;
                
            }
        }
    }
}
