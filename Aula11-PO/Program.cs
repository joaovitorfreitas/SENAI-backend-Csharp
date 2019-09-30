using System;
using Aula11_PO.Controllers;

namespace Aula11_PO
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produtos1 = new ProdutosController();

            produtos1.CadastraProdutos();
            produtos1.ExibirProduto();

        }
    }
}
