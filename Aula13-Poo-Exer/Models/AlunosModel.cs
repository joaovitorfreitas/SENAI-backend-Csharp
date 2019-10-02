namespace Aula13_Poo_Exer.Models
{
    public class AlunosModel
    {
        public string Nome {get; set;}
        public string Curso {get; set;}
        public int Idade {get; set;}
        public string Rg {get; set;}

        public bool Bolsista {get; set;}
        

        public AlunosModel(string nome, string Curso, int idade, string rg, bool bolsista){
            this.Nome = nome;
            this.Curso = Curso;
            this.Idade = idade;
            this.Rg = rg;
            this.Bolsista = bolsista;

        }
    }
}