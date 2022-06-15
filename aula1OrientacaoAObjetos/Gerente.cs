using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class Gerente
    {
        public string? nome;
        public double salario;

        public void AumentaSalario()
        {
            this.AumentaSalario(0.1);
        }

        public void AumentaSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }

        public double AumentaSalario1(double taxa)
        {
            double novoSalario = this.salario += this.salario * taxa;
            // novoSalario = 5000 +  1250 -> 6250
            return novoSalario;
        }

        public void AplicaBonus(double salarioSBonus)
        {
            this.salario = salarioSBonus + 1000;
        }

        public void testeSoma(int x, int y, int z)
        {
            if (x > 0 && y > 0 && z > 0)
            {
                int soma = x + y + z;
            }
        }
        
    }
}
