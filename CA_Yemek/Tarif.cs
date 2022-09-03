using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Yemek
{
    public class Tarif : Yemek
    {

        public static string Yıka()
        {
            return "Domatesleri ve yumurtaları yıka";
        }
        public static string Rendele()
        {
            return "Kaşarı rendele";
        }
      
        public static string Dogra()
        {
            return "Domatesleri küp şeklinde doğra";
        }

        public static string Kır()
        {
            return "Yumurtaları kır ve cam kasenin içine yumurtanın sarısını at";
        }

        public static string Cirp()
        {
            return "Rendelediğimiz kaşarı cam kasenin içine dök ve çatal ile çırp";
        }
       
        public static string OcagiYak()
        {
            return "Sıvı yağını tavanın üstüne döküp ocağı yak ve küp şeklinde doğranan domatesleri tavanın içine at";
        }

        public static string Dok()
        {
            return "Domatesleri iki üç dakika kısık ateşte pişirdikten sonra cam kasede yumurta ile rendelemiş kaşarı tavanın içine dök";
        }

        public static string Pisir()
        {
          return "Tavanın üstünü kapat ve orta ateşte 5 dakika pişir";
        }

        public static string BaharatDok()
        {
            return "Piştikten sonra omletin üstüne nane dök";
        }
    }
}
