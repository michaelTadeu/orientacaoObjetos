using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class TesteControlePonto
    {
        public static void Main(string[] args)
        {
            ControlePonto controlePonto = new ControlePonto();

            Gerente gerente = new Gerente();
            Funcionario func = gerente;
            func.codigo = 1;

            controlePonto.registraEntrada(func);
            controlePonto.registrarSaida(func);


        }
    }
}
