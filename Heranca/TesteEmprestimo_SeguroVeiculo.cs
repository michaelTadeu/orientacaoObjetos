using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class TesteEmprestimo_SeguroVeiculo
    {
        static void Main(string[] args)
        {
            Emprestimo emp = new Emprestimo();
            SeguroVeiculo segVec = new SeguroVeiculo();
            FinanciamentoCasa finCasa = new FinanciamentoCasa();

            Console.WriteLine("Emprestimo: " + emp.CalculaTaxa());
            Console.WriteLine("Seguro de Veiculo: " + segVec.CalculaTaxa());
            Console.WriteLine("Financiamento de Casa: " + finCasa.CalculaTaxa());


        }

    }
}
