using System;

namespace Aula3exercicios3 {
    class Program {
        static void Main (string[] args) {
            int usu;
            int cont = 1;

            Console.Write ("Escreva o numero maximo");
            usu = int.Parse (Console.ReadLine ());

            while (cont <= usu) {

                if (cont % 5 == 0) {
                    Console.WriteLine (cont);
                }
                cont++;
            }

        }
    }
}