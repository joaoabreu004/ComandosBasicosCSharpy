using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            // O Int é um tipo de variável que suporta apenas 32 bits.
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // <- Aqui estou realizando um casting. Mudando um double para int. 

            Console.WriteLine(salarioEmInteiro);
            
            //O long é um tipo de variável que suporta até 64 bits. 
            long idade;
            idade = 13000000000000;
            Console.WriteLine(idade); 
            
            // O short é um tipo de variável que suporta apenas 16 bits. 
            short QuantidadedeProdutos;
            QuantidadedeProdutos = 12;
            Console.WriteLine(QuantidadedeProdutos); 

            // O float "não trás precisão e suporte muito grande". 
            float altura = 1.80f; // <- Essa é a forma mais usual de declarar uma variável. 
            Console.WriteLine(altura); 

            Console.ReadLine(); 
        
        }
    }
}
