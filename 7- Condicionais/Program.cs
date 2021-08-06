using System;

namespace _7__Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");


            // Console.WriteLine("Informe o seu nome: ");
            // string nome = Console.ReadLine

            int idadeJoao = 18;
            int quantidadedePessoas = 2; 

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadedePessoas >= 2)
                {
                    Console.WriteLine("João não é maior de idade, mas está acompanhado. Pode entrar!");
                }
                else
                {
                   Console.WriteLine("João não tem mais que 18 ano de idade, não pode entrar.");

                }


            }



        }
    }
}
