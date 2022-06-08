using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class TesteGerente
    {
        static void Main(string[] args)
        {
            Gerente ge = new Gerente();
            ge.salario = 5000;

            Console.WriteLine("Salário: " + ge.salario);

            Console.WriteLine("Aumentar Salário em 10%");
            ge.AumentaSalario();
            Console.WriteLine("Salario Atual com 10%: " + ge.salario);

            Console.WriteLine("Aumenta salário em 50%");
            ge.AumentaSalario(0.5);
            Console.WriteLine("Salario Atual com 50%: " + ge.salario);

            double novoSalarioSBonus = ge.AumentaSalario1(0.25);
            // novoSalarioSBonus = 6250
            ge.AplicaBonus(novoSalarioSBonus);
            Console.WriteLine("Bonificação: " + ge.salario);

            int x1 = 20, x2 = 21, x3 = 0;
            
            ge.testeSoma(x1, x2, x3);

        }


    }
}
