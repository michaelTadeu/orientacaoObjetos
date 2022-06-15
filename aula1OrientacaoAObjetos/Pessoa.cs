using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class Pessoa
    {
        public string? nome;
        public DateTime dataNascimento;
        public float peso;
        public float altura;

        public void imprimirResultado()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de Nascimento: " + dataNascimento);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Altura: " + altura);

            int anoAtual = DateTime.Today.Year;

        }

        int calculaIdadePessoa()
        {
            return DateTime.Today.Year - dataNascimento.Year;
        }

        internal float calculaIMCPessoa()
        {
            return peso / (altura * altura);
        }

        private bool teste()
        {
            return true;
        }


    }
}
