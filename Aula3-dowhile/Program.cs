using System;

namespace Aula3_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            int acumuladora = 0;
            int numeros = 1;
            int cont2 = 1;

            do {

                if (numeros % 3 == 0) {
                    numeros = numeros + acumuladora;
                    cont2++;

                }
                cont++;
                Console.Write (numeros);

            } while (cont <= 20);
        }
    }
}
