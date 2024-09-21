namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Armazenamento { get; set; } // em GB
        public int Ram { get; set; } // em GB
        public bool Wifi { get; set; }
        public bool Bluetooth { get; set; }

        public Smartphone(string numero, string modelo, string marca, int armazenamento, int ram, bool wifi, bool bluetooth)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            Armazenamento = armazenamento;
            Ram = ram;
            Wifi = wifi;
            Bluetooth = bluetooth;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
