using System;

namespace Exercicios1 {
    class Program {
        static void Main (string[] args) {

            double numero;
            double porcentagem;

            try {
                Console.WriteLine ("Digite o valor: ");
                numero = double.Parse (Console.ReadLine ());
                Console.WriteLine ("Digite o desconto: ");
                porcentagem = double.Parse (Console.ReadLine ());

                Console.WriteLine ("O seu valor convertido é: " + Conversao (numero, porcentagem));
            } catch (Exception) {
                Console.WriteLine ("Ops :( Deu ruim. Erro: ");

            }
        }

        static double Conversao (double numero, double porcentagem) {

            try {
                double Media = numero * porcentagem / 100;

                return Media;
            } catch (Exception) {
                Console.WriteLine ("Ops :( Deu ruim. Erro: ");
                return 0;
            }

        }
    }

}