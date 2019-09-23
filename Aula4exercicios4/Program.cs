using System;

namespace Aula4exercicios4 {
    class Program {
        static void Main (string[] args) {
            string[] p1 = new string[15];
            string[] p2 = new string[15];
            string[] p3 = new string[30];

            for(int i = 0; i <=14; i++){
                Console.WriteLine("Digite 15 palavras");
                p1[i] = Console.ReadLine();
                
            }
            for(int i = 0; i <=14; i++){
                Console.WriteLine("Digite as outras 15 palavras");
                p2[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 14; i++){
                p3[i] = p1[i];
                p3[i + 15] = p2[i]; 
            }
            for(int i = 0; i <= 29; i++){
                Console.WriteLine(p3[i]);
            }
        }
    }
}