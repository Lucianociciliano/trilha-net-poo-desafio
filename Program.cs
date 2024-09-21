using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando a classe Nokia
            Console.WriteLine("Testando Nokia:");
            var meuNokia = new Nokia("123456789", "Nokia 3310", "Nokia", 16, 0, false, false);
            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            meuNokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine();

            // Testando a classe Iphone
            Console.WriteLine("Testando iPhone:");
            var meuIphone = new Iphone("987654321", "iPhone 12", "Apple", 64, 4, true, true);
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();
            meuIphone.InstalarAplicativo("Instagram");
        }
    }
}
