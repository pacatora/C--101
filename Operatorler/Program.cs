using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           int a=3;
           int b=5;
           bool sonuc=a<b;


           Console.WriteLine(sonuc);
           sonuc=a>b;
           Console.WriteLine(sonuc);
           
           sonuc= a==b;
           Console.WriteLine(sonuc);
           sonuc= a!=b;
           Console.WriteLine(sonuc);



           int sayi1=5;
           int sayi2=3;
           int sonuc1=sayi1+sayi2;
           Console.WriteLine(sonuc1);
           sonuc1=sayi1/sayi2;
           Console.WriteLine(sonuc1);
           sonuc1=sayi1%sayi2;
           Console.WriteLine(sonuc1);
           sonuc1+=1;
           Console.WriteLine(sonuc1);
        }
    }
}
