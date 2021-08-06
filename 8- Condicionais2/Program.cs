using System;

namespace _8__Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8  - Condicionais2");


            // Console.WriteLine("Informe o seu nome: ");
            // string nome = Console.ReadLine

            int idadeJoao = 18;
            //int quantidadedePessoas = 2;
            bool acompanhado = false; 


            // Variaveis booleanas 

            // bool acompanhado = quantidadedePessoas >= 2; 





            if (idadeJoao >= 18 && acompanhado == true) // <- O || substitui "or". Ou o "and" é substituido pelos "&&". 
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
               Console.WriteLine("Não pode entrar.");
            }
        }
    }
}
