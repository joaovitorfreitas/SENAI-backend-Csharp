using System;

namespace Aula4exercicios2 {
    class Program {
        static void Main (string[] args) {
            int[] numeros1 = new int[3];
            int[] numeros2 = new int[3];
            int[] numeros3 = new int[6];

            for (int i = 0; i <= 2; i++) {
                Console.WriteLine ("Digite os numeros da primeira sequencia");
                numeros1[i] = int.Parse (Console.ReadLine ());
            }
            for(int i = 0; i <= 2; i++){
                Console.WriteLine ("Digite os segunda sequencia");
                numeros2[i] = int.Parse (Console.ReadLine ());

            }

            
            for (int i = 0; i < 6; i++) {                
                numeros3[i] = numeros1[i];
                numeros3[numeros1.Length - 1] = numeros2[i]; 

                

            }

            for (int i = 0; i < 6; i++) {
                Console.WriteLine (numeros3[i]);
            }

        }
    }
}