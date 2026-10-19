namespace _15_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "C# Dersleri Başladı";
            string[] metinler = { "Merhaba", "String", "Methodlar" };
            string ad = "Erkan";
            string soyad = "Türk";
            string text = "    String Methodlar    ";
            Console.WriteLine($"String Uzunluğu:{metin.Length}");
            Console.WriteLine($"String Büyültme:{metin.ToUpper()}");
            Console.WriteLine($"String Küçültme:{metin.ToLower()}");
            string varMi = metin.Contains("C#") ? "Var" : "Yok";
            Console.WriteLine(varMi);

            string degistir = metin.Replace("C#", "CSharp");
            Console.WriteLine(degistir);

            string seperator = string.Join("=>", metinler);
            Console.WriteLine(seperator);

            string birlestirme = string.Concat(ad, " ", soyad);
            Console.WriteLine(birlestirme);
            Console.WriteLine("Boşluklarından arındırma " + text.Trim());

            string[] diziyeDonusum = metin.Split(' ');//belirtilen karakteri gördüğünde ilk yapı ayrı ikinci yapı ayrı karakterler sayılacak

            foreach (string item in diziyeDonusum)
            {
                Console.WriteLine(item);
            }

            string lang = "C# String Hazır Methodlar";

            string alinanMetin = lang.Substring(0, 6);
            Console.WriteLine(alinanMetin);

            //belirtirlen karakterle mi başıyor ?
            Console.WriteLine(lang.StartsWith("C#"));

            string metinsel = null;
            string metinsel5= null;
            string metinsel2 = "          ";
            string metinsel3 = "";



            Console.WriteLine(string.IsNullOrEmpty(metinsel));
            Console.WriteLine(string.IsNullOrEmpty(metinsel3));
            Console.WriteLine(string.IsNullOrWhiteSpace(metinsel2));

            Console.WriteLine(string.Equals(metinsel,metinsel3));//değerleri karşılaştırır.

            Console.WriteLine(string.Equals(metinsel2,metinsel3));

            Console.WriteLine(string.Compare(metinsel, metinsel5));
          

        }
    }
}
