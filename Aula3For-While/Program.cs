using System;

namespace Aula3 {
    class Program {
        static void Main (string[] args) {
            // //LAÇO CONTADO-FOR
            for (int cont = 1; cont <= 100; cont++) {

                //  Verificamos se o número é diferente de par
                if (cont % 2 != 0) {
                    Console.WriteLine ("For 100-0 " + cont);
                }
            }
            //  Laço - for - decremento (-)
            for (int cont = 100; cont >= 0; cont--) {

                //Verificamos se o número é diferente 
                if (cont % 2 != 0) {

                    Console.WriteLine ("For 0-100 " + cont);
                }
            }
           // Laço Condicional - While

            double nota = 0;
            double acumuladora = 0;
            int cont2 = 0;
            string sair = "";

            while (sair != "sim") {

                Console.Write ("Digite a nota de um aluno: ");
                nota = double.Parse (Console.ReadLine ());

                acumuladora += nota;
                cont2++;

                Console.Write ("Deseja sair da aplicacao? sim/nao");
                sair = Console.ReadLine ().ToLower ();
            }
            Console.WriteLine ("Média das notas :" + (acumuladora / cont2));
        }
    }
}