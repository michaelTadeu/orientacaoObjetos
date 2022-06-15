using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Emprestimo : Servico
    {
        public double valor;
        public double taxa;

        public Emprestimo()
        {
            Console.WriteLine("Emprestimo");
        }

        public override double CalculaTaxa()
        {
            return base.CalculaTaxa()  + this.valor * 0.1;
        }

    }
}
