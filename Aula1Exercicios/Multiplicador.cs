using System;

namespace Aula1Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float media;

            Console.WriteLine();

            Console.WriteLine("Bem vindo ao multiplicador");
            
            Console.WriteLine("Insira seu numero ");
            num1 = float.Parse(Console.ReadLine());

            media = num1* 3;

            Console.WriteLine($"Seu numero é {media}");
    
        }
    }
}
