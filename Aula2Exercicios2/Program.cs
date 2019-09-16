using System;

namespace Aula2Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            double preço;
            double media;

            Console.WriteLine("Digite seu salario");
            preço = double.Parse(Console.ReadLine() );

            media = preço + 25;

            if(preço > 100){
                Console.WriteLine($"O seu valor total é {preço} ");
            }else{
                Console.WriteLine($"Seu valor total é {media} ");
            }
        }
    }
}
