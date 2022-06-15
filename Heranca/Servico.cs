using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Servico
    {
        // Dados Gerais
        public Cliente contratante;
        public Funcionario responsavel;
        public string dataContratacao;

        public Servico(string teste)
        {
            Console.WriteLine("Serviço");
        }

        public virtual double CalculaTaxa()
        {
            double valorTaxa = 5;
            //if (this.contratante.nome == "Michael")
            //{
            //    valorTaxa = 100;
            //} else
            //{
            //    valorTaxa = 5;
            //}

            return 5;
        }








        //// Dados de Emprestimo
        //public double valor;
        //public double taxa;

        //// Dados do Seguro do Veiculo
        //public Veiculo veiculo;
        //public double valorSeguroVeiculo;
        //public double franquia;

        //// Dados Financiamento de Casa
        //public Casa casa;
        //public double valorCasa;
        //public double taxaImoveis;
    }
}
