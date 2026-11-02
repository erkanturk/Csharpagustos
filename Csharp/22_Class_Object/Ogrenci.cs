using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Class_Object
{
    internal class Ogrenci
    {
        //Private olan Ogrenci değeri varsayılan olarka 0 olacak Sınıf dışında çağırılamadığı için sınıf içinde değerini verdim

        private int OgrenciNo { get; set; } = 0;
        private string OgrenciAd { get; set; } = string.Empty;//propertynin boş olabileceğini belirttik

        private string OgrenciSoyad { get; set; } = "";

        private string? Bolumu { get; set; }//? veritabanında null bırakılabilen bir alan (allow nulls)

        private void TestY()
        {
            OgrenciAd = "Erkan";
            OgrenciSoyad = "Türk";
            Bolumu = "Yazılım";
            Console.WriteLine($"Öğrenci No:{OgrenciNo}");
            Console.WriteLine($"Öğrenci OgrenciAd:{OgrenciAd}");
            Console.WriteLine($"Öğrenci OgrenciSoyad:{OgrenciSoyad}");
            Console.WriteLine($"Öğrenci Bolumu:{Bolumu}");
        }



    }
}
