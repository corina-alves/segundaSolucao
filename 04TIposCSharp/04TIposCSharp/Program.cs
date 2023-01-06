namespace _04TIposCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minInteiro = int.MinValue;
            int maxInteiro = int.MaxValue;
            Console.WriteLine("valor Mínimo inteiro: " + minInteiro + " - " + minInteiro.GetType()); 
            Console.WriteLine("Valor maximo inteiro: " + maxInteiro);

            long ninLong = long.MinValue;
            long maxLong = long.MaxValue;

            Console.WriteLine("Valor Mínimo inteiro: " + ninLong + " - " + ninLong.GetType());
            Console.WriteLine("Valor Máximo inteiro: " + maxLong);
        }
    }
}