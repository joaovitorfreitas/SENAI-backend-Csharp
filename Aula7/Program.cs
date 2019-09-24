using System;

namespace Aula7 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("Digite o cpf: ");
            string cpf = Console.ReadLine();

            Console.WriteLine(validaCPF(cpf));

        }


        /// <summary>
        /// Validação do cpf do usuario
        /// </summary>
        /// <param name="cpfUsuario"></param>
        /// <returns>Valida e retorna o cpf do usuario</returns>
        static bool validaCPF (String cpfUsuario) {

            bool resultado = false;

            int[] v1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string CpfCalcula = "";

            int resto = 0;
            int Calculo = 0;

            string digito_v1 = "";
            string digito_v2 = "";

            CpfCalcula = cpfUsuario.Substring (0, 9);

            for (int i = 0; i <= 8; i++) {
                Calculo += int.Parse(cpfUsuario[i].ToString()) * digito_v1[i];
            }
            resto = Calculo % 11;
            Calculo = 11 - Calculo;

            if(Calculo > 9){
                digito_v1 = "0";
            }else{
                digito_v1 = Calculo.ToString();
            }

            if(digito_v1 == cpfUsuario[9].ToString() ){
                resultado = true;
            }

            int[] v2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            resto   = 0;

            CpfCalcula = CpfCalcula + Calculo.ToString();

            Calculo    = 0;

            //  for (int i = 0; i <= 9; i++) {
            //     Calculo += int.Parse(cpfUsuario[i].ToString()) * v2[i];
            // }
            // resto = Calculo % 11;
            // Calculo = 11 - Calculo;

            // if(Calculo > 9){
            //     digito_v2 = "0";
            // }else{
            //     digito_v2 = Calculo.ToString();
            // }

            // if(digito_v2 == cpfUsuario[10].ToString() ){
            //     resultado = true;
            // }

            return resultado;
        }
    }
}