using System;
using System.Collections.Generic;
using System.Text;

namespace _25_Encapsulation_2
{
    internal class Araba
    {
        private double Hiz;
        private const double MaxHiz = 250;

        public double _Hiz
        {
            get { return Hiz; }

            set
            {
                if (value >= 0 && value <= MaxHiz)
                {
                    Hiz = value;
                    Console.WriteLine($"Güncel Hız: {Hiz} km/saat");
                }
                else if (value > MaxHiz)
                {
                    Console.WriteLine($"Hız {MaxHiz} km/saat'i geçemez");
                }
                else
                {
                    Console.WriteLine("Hız Negatif olamaz");
                }
            }
        }
        public void Hizlan(double artis)
        {
            if (artis <= 0)
            {
                Console.WriteLine("Hızlanma miktarı pozitif olmalı");
                return;//eğer if yapısının içerisine girerse aşağısındaki kodları okuma
            }

            double yeniHiz = Hiz + artis;
            if (yeniHiz > MaxHiz)
            {
                Hiz = MaxHiz;
                Console.WriteLine($"Araç maksimum hız olan {MaxHiz} km/saat'e ulaştı ve sabitlendi");
            }
            else
            {
                Hiz = yeniHiz;
                Console.WriteLine($"Hızlandı. Şu anki hızınız: {Hiz} km/saat");
            }
        }
        public void Yavasla(double azalis)
        {
            if (azalis <= 0)
            {
                Console.WriteLine("Yavaşlama miktarı pozitif olmalıdır.");
                return;
            }

            Hiz -= azalis;
            if (Hiz <= 0)
            {
                Hiz = 0;
                Console.WriteLine("Araç durdu ve stop etti. Hız:0 km/saat");
            }
            else
            {
                Console.WriteLine($"Yavaşladı. Şu anki hızınız: {Hiz} km/saat");
            }
        }
    }
}
