using System;

namespace Salih
{



    //type safety = tip güvenliği
    //Do not repeat yourself = kendini tekrarlama
    class Program
    {
       

        static void Main(string[] args) 
        {

            string kategoriEtiketi = "kategoriler";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.35;
            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("azalış oku");
             
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("artış oku");
            }
            
            else
            {
                Console.WriteLine("eşitlik oku");
            }

            Console.WriteLine(dolarDun < dolarBugun ? "dolar arttı" : "dolar azaldı");





            Console.WriteLine("hangiMevsimdeyiz");


            string a = Console.ReadLine();

            switch (a)
            { 
                case "1":
                    Console.WriteLine("anladım");
                    break;
                    
                default:
                    Console.WriteLine("iyice anladım");
                    break;
                   
            }
        }
    }
}
