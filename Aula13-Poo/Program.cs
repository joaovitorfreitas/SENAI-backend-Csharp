using System;
using System.Collections.Generic;
using Aula13_Poo.Models;

namespace Aula13_Poo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instaciamos nossa classe com
            //o método construtor passando parâMETROS
           ProdutoModel produto = new ProdutoModel(1, "Maça", "Verda", 3.5);

           //Chamamos um atributo do objeto instaciando
           Console.WriteLine(produto.NomeProduto);

           //instaciamos nossa classe
           //sem passar parâmetros utilizando sobrecarga
           ProdutoModel produto_sobrecarga = new ProdutoModel();

           //Alimentamos nosso objeto que estava vazio
           produto_sobrecarga.IdProduto = 1;
           produto_sobrecarga.NomeProduto = "Melão";
           produto_sobrecarga.Descricao = "Amarelo";
           produto_sobrecarga.Preco = 5.50;

           //Chamamos a nossa lista que vai se do
           //objeto ProdutoModel
           List<ProdutoModel> prod = new List<ProdutoModel>(); 


            //Adicionamos objetos instanciados e atribuidos
            // em nossa lista
           prod.Add( new ProdutoModel( 1, "Cenoura", "Laranja", 2.30));
           prod.Add( new ProdutoModel( 2, "mamão", "Laranja", 2.30));
           prod.Add( new ProdutoModel( 3, "Beterraba", "Laranja", 2.30));
           prod.Add( new ProdutoModel( 4, "Pastel", "Laranja", 2.30));
           prod.Add( new ProdutoModel( 5, "Caldo de cana", "Laranja", 2.30));
           prod.Add( new ProdutoModel( 6, "Chuchu", "Laranja", 2.30));

            //Lemos os dados da nossa lista
           foreach(ProdutoModel p in prod){
               Console.WriteLine();

               Console.WriteLine(p.NomeProduto);
               Console.WriteLine(p.Descricao);
               Console.WriteLine(p.Preco);
           }

           // Chamamos através do indice um elemento especifico
           Console.WriteLine(prod[4].NomeProduto);
        


        }
    }
}
