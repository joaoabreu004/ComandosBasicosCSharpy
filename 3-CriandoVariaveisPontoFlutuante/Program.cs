﻿using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3 Criando Variaveis ponto Flutuante");


            double salario;
            salario = 1200.70;

            Console.WriteLine("Seu salário é: R$" + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);


            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair. . . ");
            Console.ReadLine();  
        }
    }
}
