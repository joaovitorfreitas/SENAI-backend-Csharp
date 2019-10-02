using System;
using Capitain_American.Controllers;

namespace Capitain_American
{
    class Program
    {
        static void Main(string[] args)
        {

            CapitainAmerica capetin = new CapitainAmerica();
            HomenDeFerro homezin = new HomenDeFerro();

                int selecao;

                Console.WriteLine("Selecione um personagem");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1-Capitão America!");
                Console.WriteLine("2-Homen de ferro!");
                Console.WriteLine("-----------------------");
                
                selecao = int.Parse(Console.ReadLine());

                if(selecao == 1){
                    capetin.habilidades();
                }else if(selecao == 2){
                    homezin.habilidades1();
                }else{
                    Console.WriteLine("Habilidade não reconhecida!");
                }
         }
    }
}
