using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("12345", "Nokia Tijolão", "111111111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando iPhone:");
        Smartphone iphone = new Iphone("67890", "iPhone 15", "999999999999999", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}