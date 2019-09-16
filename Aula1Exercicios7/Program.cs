using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int passageiros;
            float total;

            Console.WriteLine("Digite o numero de passageiros");
            passageiros = int.Parse(Console.ReadLine());

            total = passageiros * 4.30f;

            Console.WriteLine($"Valor total é: {total}");


        }
    }
}
