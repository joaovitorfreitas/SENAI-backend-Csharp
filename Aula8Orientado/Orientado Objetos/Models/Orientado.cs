namespace Orientado_Objetos.models
{
    public class Orientado
    {
        public string nome{get; set;}
        
        public string curso{get; set;}

        public string Ra{get; set;}

        public int idade{get; set;}

        public void estudar (){
            System.Console.WriteLine("Estou estudando");
        }
        public void intervalo (){
            System.Console.WriteLine("Olha o horario professor, O intervalo!");
        }
        public void ajuda (){
            System.Console.WriteLine("Paulo, Cola aquí!");
        }
        public void cadastraAluno(){

            System.Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            System.Console.WriteLine("Digite o curso do aluno: ");
            curso = Console.ReadLine();

            System.Console.WriteLine("Digite a idade do aluno: ");
            idade = int.Parse(Console.ReadLine());
        }
        public void exibirAluno(){
            Console.WriteLine("O nome do aluno do aluno é " + nome );
            Console.WriteLine("O Curso do aluno do aluno é " + curso );
            Console.WriteLine("A idade do aluno do aluno é " + idade );
            
        }
    }
}