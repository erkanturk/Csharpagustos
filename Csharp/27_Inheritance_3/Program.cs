namespace _27_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Suv suv = new Suv()
            {
                ArabaId = 1,
                ArabaMarka = Console.ReadLine(),
                ArabaModel="XC90",
                Ceker=true,
                Renk="Siyah",
                Yakit=YakitTuru.Dizel,
                Vites="Otomatik"
            };
          
            suv.ArabaBilgileri();

            Sport sport = new Sport();
           
            sport.ArabaMarka = "Nissan";
            sport.ArabaModel = "GTR35";
            sport.Cabrio = false;
            sport.ArabaId = 321;
            sport.Vites = "Manuel";
            sport.Yakit = YakitTuru.Benzin;
            sport.Renk = "Mat Siyah";
            sport.ArabaBilgileri();
        }
    }
}
