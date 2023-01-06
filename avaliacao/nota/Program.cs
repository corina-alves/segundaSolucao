namespace nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quero cadastrar 2 alunos e suas 2 duas notas
            //quero calcular a média destas notas
            //se média maior 6 aprovado senão 
            string aluno1 = "Michael";
            string aluno2 = "Andrea";

            double a1n1 = 8.0;
            double a1n2 = 9.5;
            double a2n1 = 8.9;
            double a2n2 = 7.5;

            double ma1 = (a1n1 + a1n2)/2 ;
            double ma2 = (a2n1 + a2n2)/2;

            if(ma1 > 6)
            {
                Console.WriteLine($"Media aluno: {aluno1} - {ma1}");

            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            if (ma2 > 6)
            {
                Console.WriteLine($"Media aluno: {aluno2} - {ma2}");

            }
            else
            {
                Console.WriteLine("Reprovado!");
            }





        }
    }
}