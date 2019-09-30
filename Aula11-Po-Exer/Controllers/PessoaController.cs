using System;
using Aula11_Po_Exer.models;

namespace Aula11_Po_Exer.Controllers
{
    public class PessoaController
    {
        PessoaModel pessoaa = new PessoaModel();

        public void cadastro(){
            Console.WriteLine("Digite seu nome: ");
            pessoaa.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite sua Idade: ");
            pessoaa.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu peso: ");
            pessoaa.Peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite sua altura: ");
            pessoaa.Altura = double.Parse(Console.ReadLine());

        }
        public void CalculoIMG(){

        double quilo;

        quilo = pessoaa.Peso/ 1000;
        


        }
    }
}