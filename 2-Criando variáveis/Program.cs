using System;

namespace _2_Criando_variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variaveis ");

            int idade;
            idade = 17;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 17;
            Console.WriteLine("Sua idade é " + idade + "!");

            idade = 10 + (5 * 2);
            Console.WriteLine(idade);

            Console.WriteLine("Execução finalizada. Tecle enter para sair . . . ");
            Console.ReadLine(); 
        }
    }
}
