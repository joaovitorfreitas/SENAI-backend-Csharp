using System;

namespace Aula4exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros1 = new int[10];
            int [] numeros2 = new int[10];

            for(int i = 0; i <= 9; i++){
                Console.WriteLine("Digite um numero");
                numeros1[i] =int.Parse(Console.ReadLine());
            }
            for(int i = 0; i <= 9; i++){
                numeros2[i] = numeros1[i];


            }
            for(int i = 0; i <= 9; i++){
                
            Console.WriteLine(numeros1[i]);
                

            }
              Console.WriteLine("Ultimo valor multiplicando por 5 é : " + numeros1[9] * 5);
            
        }
    }
}
