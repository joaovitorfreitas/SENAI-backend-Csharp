using System;

namespace Aula2Exerciciospt1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            string resultado;

            Console.Write("Por Favor Digite o numero do pedido");
            numero = (Console.ReadLine());

            switch(numero){
                case "1":
                resultado = "Hamburguer";
                break;

                case "2":
                resultado = "Cheese Salada";
                break;

                case "3":
                resultado = "Cheese buguer";
                break;

                case "4":
                resultado = "Cheese bacon";
                break;

                default:
                resultado = "Entrada invalida, apenas numeros de 1-4.";
                break;
            }
            Console.WriteLine(resultado);
        }
    }
}
