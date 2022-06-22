using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class TesteAlunoTurma
    {
        public static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Turma turma = new Turma();
            aluno.turma = turma;

            aluno.nome = "Michael Tadeu";
            aluno.rg = 123456789;
            aluno.dataNascimento = DateTime.Now;

            aluno.turma.periodo = "Manhã";
            aluno.turma.serie = "3a série";
            aluno.turma.sigla = "A";
            aluno.turma.tipoEnsino = "Médio";

            Console.WriteLine("Aluno: ");
            Console.WriteLine("Nome: " + aluno.nome);
            Console.WriteLine("RG: " + aluno.rg);
            Console.WriteLine("Data de Nascimento: " + aluno.dataNascimento);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Turma 1:");
            Console.WriteLine("Período: " + aluno.turma.periodo);
            Console.WriteLine("Série: " + aluno.turma.serie);
            Console.WriteLine("Sigla: " + aluno.turma.sigla);
            Console.WriteLine("Tipo Ensino: " + aluno.turma.tipoEnsino);
        }
    }
}
