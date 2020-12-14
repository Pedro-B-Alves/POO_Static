namespace POO_Static
{
    public class Conversor
    {
        private static float CotacaoDolar = 5.12f;
        private static float CotacaoEuro = 6.22f;

        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float DolarParaReais(float valorUS){
            return CotacaoDolar * valorUS;
        }

        public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }

        public static float EuroParaReais(float valorEUR){
            return CotacaoEuro * valorEUR;
        }
    }
}