namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Construtor da classe derivada chamando o construtor da classe base
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo: {nome} Nokia");
        }


    }
}