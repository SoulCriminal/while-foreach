using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz!");
            int sayi = int.Parse(Console.ReadLine());

            int sayac = 1 ;
            int toplam=0;
        
            while(sayac<=sayi){
                toplam += sayac;
                sayac ++;

            }
            Console.WriteLine("Ortalaması" +toplam/sayi);

            // a dan z ye kadar alfabeyi yazdıralım

            char character = 'a';
            while(character<'z'){
                Console.Write(character);
                character ++;
            }

            // FOREACH

            string [] cars = {"bmw", "porche","mercedes"};

            foreach(var item in cars){
                Console.WriteLine(item);
            }
        }
    }
}
