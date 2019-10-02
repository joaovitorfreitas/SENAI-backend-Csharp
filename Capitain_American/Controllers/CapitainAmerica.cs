using System;

namespace Capitain_American.Controllers
{
    public class CapitainAmerica
    {
        CapitainAmerica capitao = new CapitainAmerica();

        public void habilidades (){

            int ler;

            Console.WriteLine(" 1 - Pular" );
            Console.WriteLine(" 2 - Lançar Escudo");
            Console.WriteLine(" 3 - Defender com escudo ");

            ler = int.Parse(Console.ReadLine());

            if(ler == 1){
                Console.WriteLine("-Pulando-");
                
            }else if(ler == 2){
                Console.Write("Segura Meu Escudo, Haha!");
            }else if(ler == 3 ){
                Console.WriteLine("Nada Passa Pelo Meu Escudo!");
            }else{
                Console.WriteLine("Habilidade não Reconhecida!");
            }  

           
        }
         
    }
}