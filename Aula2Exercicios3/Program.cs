using System;

namespace Aula2Exercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Digite o primeiro numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = int.Parse(Console.ReadLine());


            if(num1  > num2){
                Console.WriteLine($"Seu valor maior é {num1} " );
            }else{
                Console.WriteLine($"Seu Valor maior é {num2} " );
            }
           
        }
    }
}
