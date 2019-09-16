using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeComerciante;
            float salariofx, totalvd, sfinal;
            
            Console.WriteLine("Digite seu nome");
            nomeComerciante = (Console.ReadLine());

            Console.WriteLine ("Digite seu salario fixo");
            salariofx = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total da suas vendas");
            totalvd = float.Parse(Console.ReadLine());

            sfinal = salariofx + (totalvd *1.10f);

            Console.WriteLine($" {nomeComerciante} possui um salario fixo de {salariofx} e salario total de {sfinal}");
        }
    }
}
