using System;

namespace Aula2Exercicios6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Informe sua idade");
            idade = int.Parse(Console.ReadLine());

            if(idade > 0 && idade <=5){
            Console.WriteLine($"O seu conteudo é  Early Childhood ");
            }else if(idade > 5 && idade < 10){
             Console.WriteLine($"O seu conteudo é  Everyone  ");
            }else if(idade > 9 && idade < 13){
             Console.WriteLine($"O seu conteudo é  Everyone 10+  ");
            }else if(idade > 12 && idade < 17){
             Console.WriteLine($"O seu conteudo é Teen  ");
            }else if(idade > 16 && idade < 18){
            Console.WriteLine($"O seu conteudo é  Mature 17 ");
            }else{
            Console.WriteLine($"Adults only 18+");

            }
        }
    }
}
