using System;

namespace DesafioPOO.Models
{
    // TODO resolvido → herdando de Smartphone
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // TODO resolvido → sobrescrever método
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} pela App Store...");
        }
    }
}