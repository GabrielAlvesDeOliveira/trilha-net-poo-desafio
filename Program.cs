using DesafioPOO.Models;

internal class Program
{
    public static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("00 00000-0000", "tijolao", "123123123", 16);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Wild Rift");

        Smartphone iphone = new Iphone("00 00000-0000", "11", "123123123", 16);

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Crossfire");
    }
}