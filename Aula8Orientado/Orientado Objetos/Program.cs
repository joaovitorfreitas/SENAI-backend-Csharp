using System;
using Orientado_Objetos.models;

namespace Orientado_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Orientado aluno = new Orientado();

            aluno.cadastraAluno();

            aluno.exibirAluno();
        }
    }
}
