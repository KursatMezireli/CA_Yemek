using System;
using System.Collections.Generic;

namespace CA_Yemek
{
    class Program
    {
        

        public static object Ad { get; private set; }

        static void Main(string[] args)
        {
            
            List<Malzemeler> malzemeListesi = new List<Malzemeler>();

            Malzemeler malzeme1 = new Malzemeler();
            malzeme1.İsim = "Domates";

            Malzemeler malzeme2 = new Malzemeler();
            malzeme2.İsim = "Yumurta";

            Malzemeler malzeme3 = new Malzemeler();
            malzeme3.İsim = "Kaşar";

            Malzemeler malzeme4 = new Malzemeler();
            malzeme4.İsim = "Sıvıyağ";

            Malzemeler malzeme5 = new Malzemeler();
            malzeme5.İsim = "Baharat";

            Malzemeler malzeme6 = new Malzemeler();
            malzeme6.İsim = "Tava";

            malzemeListesi.Add(malzeme1);
            malzemeListesi.Add(malzeme2);
            malzemeListesi.Add(malzeme3);
            malzemeListesi.Add(malzeme4);
            malzemeListesi.Add(malzeme5);

            foreach (Malzemeler malzemeler in malzemeListesi)
            {
                Console.WriteLine($"{ malzeme1.İsim} + {malzeme2.İsim} \n {Tarif.Yıka()}");
                Console.WriteLine($"{malzeme3.İsim} \n { Tarif.Rendele()}");
                Console.WriteLine($"{ malzeme1.İsim} \n {Tarif.Dogra()}");
                Console.WriteLine($"{malzeme2.İsim}\n {Tarif.Kır()}");
                Console.WriteLine($"{malzeme3.İsim}\n {Tarif.Cirp()}");
                Console.WriteLine($"{malzeme4.İsim} + {malzeme1.İsim} \n {Tarif.OcagiYak()}");
                Console.WriteLine($"{malzeme1.İsim} + {malzeme2.İsim} + {malzeme3.İsim} \n {Tarif.Dok()}");
                Console.WriteLine($"{malzeme6.İsim} \n {Tarif.Pisir()}");
                Console.WriteLine($"{malzeme5.İsim} \n {Tarif.BaharatDok()}");
                Console.WriteLine("Afiyet olsun :P");

               Console.ReadLine();
            }
            return;

            
        }
    }
}
