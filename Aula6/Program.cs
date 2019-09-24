using System;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Chamamos nossa primeira função
            Console.WriteLine( Bomdia("Boa Tarde"));
            //Chamamos a função do tipo VOID (sem retorno)
            ImprimeDataHora();
            
        }

        /// <summary>
        /// Função que escreve bom dia para o usuário
        /// </summary>
        /// <returns>Retorna ola! Bom dia</returns>
        static string Bomdia(){
            return "Olá Bom dia!";
        }
        


        /// <summary>
        /// Função que mostra uma saudação de acordo com horário atual 
        /// </summary>
        /// <param name="saudacao"></param>
        /// <returns>Um texto qualquer (Sobrecarga de método)</returns>
        static string Bomdia(String saudacao){

            int hora = DateTime.Now.Hour;

            if(hora <= 11 && hora >= 6){
                saudacao = "Bom dia";
            }else if(hora >= 12 && hora <= 18){
                saudacao = "Boa Tarde";
            }else{
                saudacao = "Boa noite";
            }
            return saudacao;
        }

        /// <summary>
        /// Retorna um número - Teste de sobrecarga
        /// </summary>
        /// <param name="numero">Um número inteiro qualquer</param>
        /// <returns>Número passado como parâmero</returns>
        static int Bomdia(int numero){
            return numero;
        }

        /// <summary>
        /// Função q retorna Data e atuais
        /// </summary>
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());

            //chamamos nossa função que calcula a média
            double[] numeros = {2 , 5 , 2, 8, 9, 5};

            Console.WriteLine(CalculMedia(numeros));
            
            
            Console.WriteLine(SomaMedia(numeros));
        }  


        /// <summary>
        /// Função que calcula a média de um valor
        /// </summary>
        /// <param name="valores"></param>
        /// <returns>Média doos valores</returns>
        static double CalculMedia(double[] valores){

            double resultado = 0;

            for(int i = 0; i < valores.Length ; i++){
                resultado += valores[i];

            }
            resultado = resultado / valores.Length;

            return resultado;
        }

        /// <summary>
        /// Soma dos valores
        /// </summary>
        /// <param name="valores1"></param>
        /// <returns>Devolve a soma entre todos os numeros</returns>
        static double SomaMedia (Double [] valores1){

            double resultadi = 0;

            for(int i = 0; i< valores1.Length; i++){
                resultadi += valores1[i];
            }
            return resultadi;
        }
        
        
        }
}
