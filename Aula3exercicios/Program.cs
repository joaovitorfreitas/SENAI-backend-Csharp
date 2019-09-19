using System;

namespace Aula3exercicios {
    class Program {
        static void Main (string[] args) {
            int media;
            for (int cont = 1; cont <= 100; cont++) {

                media = cont * cont * cont;

                Console.WriteLine ("For " + media);

            }
            int cont2 = 1;
            int media2;

            while (cont2 <= 100) {
                media2 = cont2 * cont2 * cont2;
                cont2++;

                Console.WriteLine ("While " + media2);

            }
            int media3;
            int cont3 = 1;
            do {
                media3 = cont3 * cont3 * cont3;
                cont3++;

                Console.WriteLine ("do While " + media3);

            } while (cont3 <= 100);

        }
    }
}