using System;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] v1 = { "A", "B", "C" };

            //Laço FOREACH (para cada)
            //Imprime na tela os indices
            foreach(string letra in v1){
                Console.WriteLine(letra);
            }   
        }
    }
}   
