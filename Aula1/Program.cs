using System;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somente declaramos, sem atribuir valor 
            int num1;

            //Declaramos atribundo um valor
            int num2 = 5;

            //Declaramos diversas variáveis de mesmo tipo
            int num3, num4, num5;

            //Variável de tipo decimal (real)
            float media;

            //Variável do tipo logico
            bool resultado = false;

            //Variável do tipo texto(caracteres)
            string nomeAluno;

            //Quebra linha
            Console.WriteLine();

            //Escrava em uma linha quebrando-a
            Console.WriteLine("Bem vindos à nossa primeira aplicação");

            //Continua escrevendo na mesma linha
            Console.Write("Digite seu nome: ");

            //Capturo o dado digitando pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();
            
            // Concatenação
            Console.WriteLine(nomeAluno + ", Agora dite sua primeira nota");

            //Converto o texto capturado para o tipo inteiro
            num3 = int.Parse(Console.ReadLine());

            // Interpoçlação
            Console.WriteLine($"Sua primeira nota é { num3 }");


            Console.WriteLine("Digite sua Segunda nota: ");
            num4 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());

            media = (num3 + num4 + num5)/3;

            Console.WriteLine($"Sua media é : { media }");

        }
    }
}
