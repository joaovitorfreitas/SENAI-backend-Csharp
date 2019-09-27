using System;

namespace Aula8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            try{
                //Escrevemos um bloco de código
                Console.WriteLine("Digite um numero: ");
                numero = Int16.Parse(Console.ReadLine()); 

            }catch(Exception ex){

                //mostramos a excessão da regra
                //erro gerado na aplicação
                Console.WriteLine("Ops :( Deu ruim. Erro: " + ex );
            }
            
        }
    }
}
