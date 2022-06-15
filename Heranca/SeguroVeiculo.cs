using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class SeguroVeiculo : Servico
    {
        public Veiculo veiculo;
        public double valorSeguroVeiculo;
        public double franquia;

        public override double CalculaTaxa()
        {
            return base.CalculaTaxa() + this.veiculo.valor * 0.5;
        }
    }
}
