using System.Reflection.Metadata;

namespace _01_ComonadosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine($" {i} x 4 = {i * 4}");
                i++; // i = i+1
            }
            Console.WriteLine("------------");

            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($" {j} x 6 = {j * 6}");
            }


        }
    }
}