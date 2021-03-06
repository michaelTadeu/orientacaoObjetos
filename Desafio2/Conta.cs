using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Conta

    //As contas do banco possuem número, saldo e limite.
    //Crie uma classe chamada Conta para definir os objetos
    //que representarão as contas do banco.
    {
        public int numero;
        public double saldo;
        public double limite = 500;
        public double contaNegativa = -200;
        public Agencia agencia;

        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }

        public void Deposito(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public bool VerificaSaldo(double valorSaque)
        {
            bool podeSacar = true;
            double saldoAtual = Saca(valorSaque);
            if (saldoAtual < contaNegativa)
            {    
                podeSacar = false;
            }

            return podeSacar;
        }

        public double Saca(double valorSaque)
        {
            double valorSacado = (saldo - valorSaque) * 10;
            return valorSacado;
        }

        public void ImprimirExtrato(int dias = 15)
        {
            // extrato dos 30 dias
            // Vai BD e busca os dados
        }

        public void ImprimirExtrato()
        {
            this.ImprimirExtrato(15);
        }

    }
}
