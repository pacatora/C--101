using System;

namespace Degiskenler
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        string str20="20";
        int int20=20;
        string yeniDeger=str20+int20.ToString();
        Console.WriteLine(yeniDeger);

        int int21= int20+Convert.ToInt32(str20);
        Console.WriteLine(int21);

        int int22= int20+int.Parse(str20);
        Console.WriteLine(int22);


        string dateTime=DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(dateTime);

        string hour=DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
        }

       

    }
}
