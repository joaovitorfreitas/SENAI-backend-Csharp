using System;

namespace Aula3exercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            
            double media;
            double salario = 1;
            int funcionarios = -1;
            double ac = 0; 

            Console.Write("\nDigite <0> para sair");
            while (salario != 0)
            {

                

                Console.WriteLine("\nDigite o salario");
                salario = double.Parse(Console.ReadLine());
                
                ac = ac + salario;

                

                funcionarios = funcionarios + cont;
                
                

            }
             media = ac / funcionarios;
            Console.WriteLine( "funcionarios é "+ funcionarios);
            Console.WriteLine("A média do salarios dos funcionarios é " + media);
        }
    }
}
