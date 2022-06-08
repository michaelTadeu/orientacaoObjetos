using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class PessoaNova
    {
        public string rg;
        public long cpf;

        public PessoaNova(string rg)
        {
            this.rg = rg;
        }

        public PessoaNova(long cpf)
        {
            this.cpf = cpf;
        }

        public PessoaNova(long cpf, long teste)
        {
            this.cpf = cpf;
        }

        public PessoaNova(long cpf, long teste, string teste2)
        {
            this.cpf = cpf;
        }
    }
}
