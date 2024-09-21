namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string marca, int armazenamento, int ram, bool wifi, bool bluetooth) 
            : base(numero, modelo, marca, armazenamento, ram, wifi, bluetooth)
        {
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no smartphone Nokia...");
        }
    }
}
