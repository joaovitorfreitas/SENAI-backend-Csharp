using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float salariofx, divida, sobra;

            Console.WriteLine("Digite seu salário");
            salariofx = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total da divida");
            divida = float.Parse(Console.ReadLine());

            sobra = salariofx - divida;

            Console.WriteLine($"Seu valor final é: {sobra}");

        }
    }
}
