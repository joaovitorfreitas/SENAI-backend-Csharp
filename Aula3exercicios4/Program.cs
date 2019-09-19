using System;

namespace Aula3exercicios4 {
    class Program {
        static void Main (string[] args) {

            int cont = 1;
            int acu = 1;
            int valor;
            int media;

            while (cont <= 20) {
                Console.WriteLine ("Insirira 20 valores");
                valor = int.Parse (Console.ReadLine ());


                if( valor < 0){
                acu = acu + valor;
                }
                cont++;

        
            }

                if(valor > 0){

                Console.WriteLine("Valor imprimido" + valor);

                }

            

             media = acu / cont;

             Console.WriteLine("média é : " + media);

                

        }
    }
}