using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos as notas que utilizaremos
            double nota1, nota2, nota3, media;

            //capturamos a primeira nota
            Console.WriteLine("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine() );

            //capturamos a segunda nota
            Console.WriteLine("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine() );

            //capturamos a terceira nota
            Console.WriteLine("Digite sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine() );

            ;
            //calculamos a média das notas
            media = (nota1 + nota2 + nota3) / 3;

            //verificamos se a media do aluno é maior ou igual à
            if(media >= 6){
                
                Console.WriteLine($"Média: {media} Aluno aprovado!");
            }else{
                 Console.WriteLine($"Média {media}Aluno reprovado");
            }
            
        }
    }
}
