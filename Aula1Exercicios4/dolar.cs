using System;

namespace Aula1Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            double real;
            double dolar;
            double media;

            Console.WriteLine("Insira o valor em real");
            real = double.Parse(Console.ReadLine());

            media = real / 4.09;

            Console.WriteLine($"valor do resultado é {media}");

            

        }
    }
}
