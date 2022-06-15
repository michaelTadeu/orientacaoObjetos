using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class CartaoCredito
    {
        public long numero;
        public string? nome;
        public string? dataDeValidade;
        public int codigoDeSeguranca;
        public Cliente cliente;

        public CartaoCredito(long pNumero, string pNome, string pDataDeValidade, int pCodigoDeSeguranca)
        {
            this.numero = pNumero;
            this.nome = pNome;
            this.dataDeValidade = pDataDeValidade;
            this.codigoDeSeguranca = pCodigoDeSeguranca;

        }

        public void imprimirResultado()
        {
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data Validade: " + dataDeValidade);
            Console.WriteLine("Código: " + codigoDeSeguranca);

        }

    }
}
