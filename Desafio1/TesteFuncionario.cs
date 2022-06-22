using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class TesteFuncionario
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Michael Tadeu";
            funcionario.salario = 1300;

            funcionario.aumentarSalario(5000);
            funcionario.consultarDadosFuncionario();
        }
    }
}
