using System;

namespace Aula1Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preço;
            float calculo;
            float porc;
            float total;
            

        
            Console.WriteLine("Digite o preço do produto");
            preço = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de acrescimo");
            porc = float.Parse(Console.ReadLine());

            calculo = (preço * porc) /100;
            total = calculo + preço;

            Console.WriteLine($"O valor desta mercadoria é {total}");
        }
    }
}
