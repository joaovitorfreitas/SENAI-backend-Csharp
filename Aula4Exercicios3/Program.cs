using System;

namespace Aula4Exercicios3 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[12];
            string[] cor = new string[12];
            double[] tamanho = new double[12];
            double[] preco = new double[12];

            for (int i = 0; i <= 11; i++) {
                Console.WriteLine ("Digite seu nome! ");
                nome[i] = Console.ReadLine ();

                Console.WriteLine ("Digite a cor! ");
                cor[i] = Console.ReadLine ();

                Console.WriteLine ("Digite o Tamanho! ");
                tamanho[i] = double.Parse (Console.ReadLine ());

                Console.WriteLine ("Digite o preço! ");
                preco[i] = double.Parse (Console.ReadLine ());

            }
            for (int i = 0; i <= 11; i++) {
                Console.WriteLine ("Os nome são: " + nome[i]);
                Console.WriteLine ("A sua Cor é: " + cor[i]);
                Console.WriteLine ("Seu tamanho é: " + tamanho[i]);
                Console.WriteLine ("Digite o preço: " + preco[i]);
            }
        }
    }
}