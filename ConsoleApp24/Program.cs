﻿using System;
using System.Diagnostics.CodeAnalysis;
namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
       
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların toplamını ekrana yazdır.
            int TekToplam = 0;
            int CiftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    TekToplam += i;
                else
                    CiftToplam += i;
            }
            Console.WriteLine("Tek Toplam: " + TekToplam);
            Console.WriteLine("Çift Toplam: " + CiftToplam);

            // Break, Continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }





        }
    }
}