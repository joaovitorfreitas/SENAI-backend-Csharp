using System;

namespace Aula2Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double gasto;
            double media;

            Console.WriteLine("Informe seu salario!");
            salario = double.Parse(Console.ReadLine() );

            Console.WriteLine("Informe seus gastos");
            gasto = double.Parse(Console.ReadLine() );
            
            media = salario - gasto;

            if(media > 0){
                Console.WriteLine("superávit");
            }else{
                Console.WriteLine("déficit");
            }
        }
    }
}
