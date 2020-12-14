using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para converter");
            float valor = float.Parse(Console.ReadLine());

            // Chamamos nossa classe estática, sem precisar instanciar
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Dolar");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine( $"Convertendo Dólar para Reais: {Conversor.DolarParaReais(valor)}" );
            Console.WriteLine( $"Convertendo Reais para Dólar: {Conversor.RealParaDolar(valor)}" );

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Euro");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( $"Convertendo Euro para Reais: {Conversor.EuroParaReais(valor)}" );
            Console.WriteLine( $"Convertendo Reais para Euro: {Conversor.RealParaEuro(valor)}" );
            Console.ResetColor();
        }
    }
}
