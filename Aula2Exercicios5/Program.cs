using System;

namespace Aula2Exercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1;
           int num2;
           int num3;

           Console.WriteLine("Insira o primeiro valor");
           num1 =int.Parse(Console.ReadLine());

           Console.WriteLine("Insira o segundo valor");
           num2 =int.Parse(Console.ReadLine());

           Console.WriteLine("Insira o terceiro valor");
           num3 =int.Parse(Console.ReadLine());

           if(num1 > num2 && num1 > num3){
               Console.WriteLine($"O Numero {num1} é maior");
            }else if (num2 > num3){
                Console.WriteLine($"O Numero {num2} é maior");
            }else{
                Console.WriteLine($"O Numero {num3} é maior");
            }
        }
    }
}
