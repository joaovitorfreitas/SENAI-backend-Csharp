﻿using System;

namespace Aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //deixamos declarada como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno;

            Console.Write("Digite sua idade ");
            idade = int.Parse(Console.ReadLine() );

            //Como ja tribuimos anteriormente, mudamos o 
            //estada da variável para verdadeira caso
            //entre nessa condição
            if(idade > 17){
                entrada = true;
            }
            if( entrada == true){
                retorno = "Entrada permitida!!!";
            }else{
                retorno = "Entrada não permitida :(";
            }
            Console.WriteLine(retorno);
        }
    }
}
