using System;

namespace Aula2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            string final;
            string resultado;

            Console.Write("Digite a placa do seu carro");
            placa = Console.ReadLine();

            //Contamos a quantidade de caracteres
            //um elemento
            int caracteres = placa.Length;

            //Pegamos o ultimo dígito
            //com método substring()
            final = placa.Substring(caracteres - 1) ;


            if(final == "1" || final== "2"){
                resultado = "IF/ELSE -Seu rodizio é na segunda-feira";
            }else if(final == "3" || final == "4"){
                resultado = "IF/ELSE -Seu rodizzio é na terça-feira";
            }else if(final == "5" || final == "6"){
                resultado = "IF/ELSE -Seu rodizio é na quarta-feira";
            }else if(final == "7" || final == "8"){
                resultado = "IF/ELSE -Seu rodizio é na Quinta-feira";
            }else if(final == "9" || final == "0"){
                resultado = "IF/ELSE -Seu rodizio é na Sexta-feira";
            }else{
                resultado = "Placa Invalida!";
            }
            Console.WriteLine(resultado);

            switch(final){
                case "1":
                resultado = "Switch - Segunda-feira";
                break;

                case "2":
                resultado = "Switch - Segunda-feira";
                break;

                case "3":
                resultado = "Switch - Terça-feira";
                break;

                case "4":
                resultado = "Switch - Terça-feira";
                break;

                case "5":
                resultado = "Switch - Quarta-feira";
                break;

                case "6":
                resultado = "Switch - Quarta-feira";
                break;

                case "7":
                resultado = "Switch - Quinta-feira";
                break;

                case "8":
                resultado = "Switch - Quinta-feira";
                break;

                case "9":
                resultado = "Switch - Sexta-feira";
                break;

                case "0":
                resultado = "Switch - Sexta-feira";
                break;

                default:
                resultado = "Switch - Entrada Invalida";
                break;
            }
            Console.WriteLine(resultado);
        }
    }
}
