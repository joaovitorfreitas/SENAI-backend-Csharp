using System;

namespace Aula4Exercicios2 {
    class Program {
        static void Main (string[] args) {
            int[] numeros1 = new int[10];
            int[] numeros2 = new int[10];
            int[] numeros3 = new int[20];

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite os numeros da primeira sequencia");
                numeros1[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite os segunda sequencia");
                numeros2[i] = int.Parse (Console.ReadLine ());

            }

            for (int i = 0; i < 9; i++) {
                numeros3[i] = numeros1[i];
                numeros3[i + 10] = numeros2[i];

            }

            for (int i = 0; i < 19; i++) {
                Console.WriteLine (numeros3[i]);
            }
        }
    }
}