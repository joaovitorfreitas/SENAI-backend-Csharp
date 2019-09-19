using System;

namespace Aula3exercicios2 {
    class Program {
        static void Main (string[] args) {

            int media;
            int tabu;
            Console.Write ("Digite o numero da tabuada");
            tabu = int.Parse (Console.ReadLine ());
            for (int cont = 1; cont <= 10; cont++) {

                media = tabu * cont;

                Console.WriteLine ("For " + media);

            }
            int cont2 = 1;
            int tabu2;
            int media2;

            Console.Write ("Digite o numero da tabuada");
            tabu2 = int.Parse (Console.ReadLine ());
            while (cont2 <= 10) {
                media2 = tabu2 * cont2;
                cont2++;

                Console.WriteLine ("While " + media2);
            }

            int cont3 = 1;
            int tabu3;
            int media3;
            Console.Write ("Digite o numero da tabuada");
            tabu3 = int.Parse (Console.ReadLine ());
            do {
                media3 = tabu3 * cont3;
                cont3++;

            } while (cont3 >= 10);

            Console.WriteLine ("do-While " + media3);

        }
    }
}