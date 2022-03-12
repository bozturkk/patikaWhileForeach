using System;

namespace While // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak console dan girilen sayıya kadar ortalama hesaplayıp console yazdıran progrma

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi) //buraya yazılan ifade true olduğu sürece çalışacaktır.
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine("sayıların ortalaması" + toplam/sayi);


            //a dan z ye kadar tüm harfleri console a yazdırma,

            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.Write(karakter + " ");
                karakter ++;
            }
            Console.WriteLine(" ");
            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar) //tüm araba değerlerini teker teker gezerek yazdırır.
            {
                Console.WriteLine(araba);
            }

        }
    }
}