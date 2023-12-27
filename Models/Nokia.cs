namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public static void InstalarAplicativo()
        {
            Console.WriteLine("Instalando pela Google Store");
        }
    }
}