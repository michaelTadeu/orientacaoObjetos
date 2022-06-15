using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class TestePessoa
    {
        public static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "José da Silva";
            p1.dataNascimento = new DateTime(1989, 4, 10);
            p1.peso = 75.56f;
            p1.altura = 1.92f;

            p1.imprimirResultado();

            //int idade = p1.calculaIdadePessoa();
            //float imc = p1.calculaIMCPessoa();

            //if (p1.teste())
            //{
                
            //} else
            //{

            //}

            //Console.WriteLine("Idade: " + idade);
            //Console.WriteLine("IMC: " + imc);
        }
    }
}
