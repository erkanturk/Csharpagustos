using System;
using System.Collections.Generic;
using System.Text;

namespace _25_Encapsulation
{
    internal class Vatandas
    {
        public string AdSoyad { get; set; }
        private long TcNo { get; set; }//burası ise sınıfın kendi değeri eğer aşağıdaki koşul sağlanmazsa bu değere
        //Atama gerçekleşmeyecek ve default olarak 0 kalacak

        public string _TcNo//Dışarıda kullanılacak yapı burası
        {
            get { return TcNo.ToString(); }

            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11 && IsAllDigits(value))
                {
                    TcNo = long.Parse(value);
                    Console.WriteLine(TcNo);
                }
                else if (value.Length != 11)
                {
                    Console.WriteLine("Tc Kimlik Numarası 11 haneli olmalıdır.");
                }
                else if (!IsAllDigits(value))
                {
                    Console.WriteLine("Tc no sayılardan oluşmalıdır.");
                }
                else if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Boşluk yada Null olamaz");
                }
                
            }
        }
        private bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;//tüm değerler sayısal olarak girildiyse true dönder;
        }
    }
}
