namespace projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variável
            //tipo nomeVariavel

            int idade = 46;
            string nome = "Professor Juan Pablo";
            float saldo = 300.30f;
            //char tipo = '1';
            //Concatenar
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(saldo);
            Console.WriteLine("---------");
            Console.WriteLine("Concatenar");

            Console.WriteLine("Placeholders");
            Console.WriteLine("O {0} tem {1} anos e saldo de R$ {2}", nome, idade, saldo);
            Console.WriteLine(" ----- ");

            Console.WriteLine("Intercalação");
            Console.WriteLine($"O {nome} tem {idade} anos e saldo de R$ {saldo}", nome, idade, saldo);
            Console.WriteLine(" ----- ");

            Console.WriteLine("Concatenação");
            Console.WriteLine("O " + nome + " tem " + idade + " anos e saldo de " + saldo);

            Console.WriteLine("-----------------");
            bool maiorDeIdade = true; //true ou false

            Console.WriteLine("É maior de Idade? " + maiorDeIdade);
        }
    }
}