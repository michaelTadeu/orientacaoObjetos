using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Aluno
    {
        public string? nome;
        public string? rg;
        public DateTime dataNascimento;

        public Aluno(string rg)
        {
            this.rg = rg;
        }

        public Aluno(string rg, string nome, DateTime dataNascimento)
        {
            this.rg = rg;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }

        public void CorrigirDadosAluno(string nome, string rg, DateTime dataNascimento)
        {
            this.nome = nome;
            this.rg = rg;
            this.dataNascimento = dataNascimento;
        }

        public void CorrigirDadosAluno(string nome)
        {
            this.nome = nome;
        }

        public void CorrigirDadosAluno(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }
    }
}
