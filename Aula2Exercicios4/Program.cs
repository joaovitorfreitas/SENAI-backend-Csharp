using System;

namespace Aula2Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            double preço;
            double media;
            double total;

            Console.WriteLine("Informe a quantidade de pagamento");
            preço = double.Parse(Console.ReadLine());

            media = (preço * 15)/100;
            total = preço - media;      

            if(preço >= 100 || preço <= 1000 ){
                Console.WriteLine($"valor fica {total} ");
            }else{
                Console.WriteLine($"Valor ficar {preço} ");
            }

            }

            
        }
    }

