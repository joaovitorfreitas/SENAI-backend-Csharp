using System;
using System.IO;
using Aula11_PO.Models;

namespace Aula11_PO.Controllers {
    public class ProdutosController {

        ProdutosModel Produto = new ProdutosModel ();

        public void CadastraProdutos () {

            try {
                Console.WriteLine ("Digite um Id do Produto: ");
                Produto.IdProduto = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite o nome do produto : ");
                Produto.NomeProduto = Console.ReadLine ();

                System.Console.WriteLine ("Digite a descrição do produto: ");
                Produto.Descricao = Console.ReadLine ();

                System.Console.WriteLine ("Digite o preço do produto: ");
                Produto.Preco = double.Parse (Console.ReadLine ());

            } catch (Exception ex) {

                Console.WriteLine("Desculpe! *-*");
                SalvarErros(ex);
            }

        }
        public void ExibirProduto () {
            System.Console.WriteLine ("Id do Produto : " + Produto.IdProduto);
            System.Console.WriteLine ("Nome do Produto : " + Produto.NomeProduto);
            System.Console.WriteLine ("Discrição do Produto : " + Produto.Descricao);
            System.Console.WriteLine ("Preço do Produto : " + Produto.Preco.ToString("F2"));
        
        }

        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            //Pega data Completo
            txt.WriteLine (DateTime.Now.ToLongDateString ());

            //Pega Coisas Importantes do tempo ex:Min, Hora
            txt.WriteLine (DateTime.Now.ToShortDateString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();

        }
    }
}