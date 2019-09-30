
namespace Aula11_PO.Models
{
    public class ProdutosModel
    {
        
        public int IdProduto{ get; set; }

        public string NomeProduto{ get; set; }

        public string Descricao{ get; set;}

        public double Preco{ get; set;}


        public ForncedoresModel Fornecedor {get; set;}
    }
}