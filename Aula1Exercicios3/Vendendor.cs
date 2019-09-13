using System;

namespace Aula1Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
        float salario;
        float totalvendas;
        float contas;
        float total;

        Console.WriteLine("Digite seu salario");
        salario = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu valor total de vendas");
        totalvendas = float.Parse(Console.ReadLine());
        
        
        total = totalvendas * 0.05f;
        contas = salario + total;

        Console.WriteLine($"O total recebido em vendas {contas}");
        

        }
    }
}
