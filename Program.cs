using Ex5;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace CobrarCorrigido
{
    class Program
    {
        static void Main()
        {
            Cobrar cobranca = new Cobrar(100, 10);
            cobranca.Calcular();
            Console.ReadLine();
        }
    }
}