using System;
using System.Collections.Generic;
using System.Text;

namespace _24_Constructor_2
{
    internal class Ogrenci
    {
        public int OgrNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DogumYili { get; set; }

        //=new List<Ogrenci>(); 
        //Bu yapı Öğrenciler varsa gösterir yoksa boş gösterir. NullReferenceException hatası almayız.
        //Yani sınıf ilk oluşturulduğunda bellekte yer açılır ve Ogrenciler listesi boş olarak gelir.
        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();

        public Ogrenci(int ogrNo, string adi, string soyadi, int dogumYili)
        {

            OgrNo = ogrNo;
            Adi = adi;
            Soyadi = soyadi;
            DogumYili = dogumYili;
            Ogrenciler.Add(this);
        }
        public Ogrenci()
        {
            
        }

        public List<Ogrenci> OgrenciListele()
        {
           List<Ogrenci> ogrencis = new List<Ogrenci>()
           {
               new Ogrenci(){OgrNo=1,Adi="Erkan",Soyadi="Türk",DogumYili=1990},
               new Ogrenci(){OgrNo=2,Adi="Ahmet",Soyadi="Yılmaz",DogumYili=1993},
               new Ogrenci(){OgrNo=3,Adi="Mehmet",Soyadi="Kaya",DogumYili=1995},
               new Ogrenci(){OgrNo=4,Adi="Ayşe",Soyadi="Demir",DogumYili=1992},
               new Ogrenci(){OgrNo=5,Adi="Fatma",Soyadi="Çelik",DogumYili=1991}
           };
            return ogrencis;
        }

    }
}
