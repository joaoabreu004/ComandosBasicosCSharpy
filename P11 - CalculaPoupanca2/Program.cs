﻿using System;

namespace P11___CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000; 

            for(int contadorMes = 1; contadorMes <= 12; contadorMes +=1)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + "meses, você terá R$" + valorInvestido);
            } 

            Console.ReadLine(); 
        }
    }
}
