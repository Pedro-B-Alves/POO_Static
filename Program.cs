using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamamos nossa classe estática, sem precisar instanciar
            Console.WriteLine( Conversor.DolarParaReais(52) );
            Console.WriteLine( Conversor.RealParaDolar(52) );
        }
    }
}
