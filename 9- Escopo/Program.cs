using System;

namespace _9__Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9  - Escopo ");



            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!"; 
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
            }


            // Variaveis booleanas 

            // bool acompanhado = quantidadedePessoas >= 2; 





            if (idadeJoao >= 18 && acompanhado == true) // <- O || substitui "or". Ou o "and" é substituido pelos "&&". 
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
                Console.WriteLine(mensagemAdicional);

            }

            Console.ReadLine(); 
        }
    }
}
