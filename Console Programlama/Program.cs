using System;

namespace Console_Programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınızı giriniz");
            string ad= Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Ad Soyad : "+ad+" "+soyad);
        }
    }
}
