using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Funcionario
    {
        public string? nome;
        public double salario = 0;

        public double aumentarSalario(double valorAumentado)
        {
            return salario += valorAumentado;
        }

        public void consultarDadosFuncionario()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário: R$ {salario.ToString("N2")}");
        }

    }
}
