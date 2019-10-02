using System;
using System.Collections.Generic;
using Aula13_Poo_Exer.Models;

namespace Aula13_Poo_Exer
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AlunosModel> al = new  List<AlunosModel>();

            al.Add( new AlunosModel("joao", "Code", 1, "123.123.1231-23", false ));

            foreach(AlunosModel p in al){
                Console.WriteLine();
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Curso);
                Console.WriteLine(p.Idade);
                Console.WriteLine(p.Rg);

                if(p.Bolsista == false){
                    Console.WriteLine("Não Bolsista");
            }      
                }

        }
    }
}

