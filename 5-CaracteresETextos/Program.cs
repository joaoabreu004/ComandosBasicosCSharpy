﻿using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // character 
            char primeiraLetra = ' '; 
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);


            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curso de Tecnologia " + 2021;
            string cursoProgramacao = @"-.NET
-JAVA
-Javascipt"; 


            Console.WriteLine(titulo);
            Console.WriteLine(cursoProgramacao); 
            

            Console.ReadLine(); 
        }
    }
}
