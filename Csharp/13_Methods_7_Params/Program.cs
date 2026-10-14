namespace _13_Methods_7_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Params
            /* Params Method
             * Params anahtar kelimesi ile birlikte methoda değişken sayıda aynı tipde değerler vermemizi sağlayan bir yapıdır.
             * Params parametresi methodun son parametresi olmalıdır. bir method da params yapısı sadece bir adet tanımlanabilir.
             * Params ile belirtilen parametre bir dizi olarak işlenir bu da method içinde bir 
             * dizi erişilebileceği ve üzerinde işlem yapabileceğimiz anlamına gelir.
             */
            #endregion
            //Yaz(10,20,40);//3. parametrede hata verir.
            //Paramsli(10, 20);
            //Paramsli(20, 30, 20, 45, 45, 99, 77, 666, 77, 755, 99, 798, 5465789, 4135, 1, 2, 3, 5, 6);

            //Paramsli2(20, 14.5, 465, 478.50, 55);
            //int[] degerler = { 20, 30, 20, 45, 45, 99, 77, 666, 77, 755, 99, 798, 5465789, 4135, 1, 2, 3, 5, 6 };
            //Yazdir(degerler);
            //Yazdir2(degerler, 564, 789, 9363, 44, 47, 8);

            //Paramsli2(degerler[0]);

           // Yazdir3("Erkan","Türk",'E',123.45,DateTime.Now.Year,true,false);
        }
        static void Yaz(int sayi, int sayi2)
        {
            Console.WriteLine(sayi+sayi2);
        }
        static void Paramsli(int sayi, int sayi2, params int[] sayilar)
        {
            Console.WriteLine(sayi + sayi2);
            Console.WriteLine("*********");
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

        }
        static void Paramsli2(params double[] doubles)
        {
            Console.WriteLine("*********");
            foreach (int item in doubles)
            {
                Console.WriteLine(item);
            }
        }
        static void Yazdir(int[] dizi)
        {
            Console.WriteLine("*********");
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void Yazdir2(int[] dizi, params double[] parametreler)
        {
            Console.WriteLine("*********");
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            foreach (int item in parametreler)
            {
                Console.WriteLine(item);
            }

        }
        static void Yazdir3(params object[] objects)
        {
            foreach (object obj in objects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
