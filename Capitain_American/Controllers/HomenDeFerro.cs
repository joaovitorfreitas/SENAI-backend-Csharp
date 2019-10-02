using System;
using Capitain_American.Models;

namespace Capitain_American.Controllers
{
    public class HomenDeFerro
    {
         IronMan homen = new IronMan();

            public void habilidades1 (){

            int ler;

            Console.WriteLine(" 1 - Pular" );
            Console.WriteLine(" 2 - Voar");
            Console.WriteLine(" 3 - Defender com escudo ");

            ler = int.Parse(Console.ReadLine());

            if(ler == 1){
                Console.WriteLine("-Pulando-");
                
            }else if(ler == 2){
                Console.Write("jarvis bora voar!, resposta : Demoro sangue bom!");
            }else if(ler == 3 ){
                Console.WriteLine("TATATATATATATATATATATATATATA");
            }else{
                Console.WriteLine("Habilidade não Reconhecida!");
            }  

            
        }


    }
}