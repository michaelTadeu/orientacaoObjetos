using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class TesteCartaoCredito
    {
        public static void Main(string[] args)
        {
            //CartaoCredito cdc1 = new CartaoCredito();
            //cdc1.numero = 5101353022928113;
            //cdc1.nome = "José da Silva";
            //cdc1.dataDeValidade = "27/03/2026";
            //cdc1.codigoDeSeguranca = 963;

            //CartaoCredito cdc2 = new CartaoCredito();
            //cdc2.numero = 4556557638379007;
            //cdc2.nome = "José da Costa";
            //cdc2.dataDeValidade = "27/06/2029";
            //cdc2.codigoDeSeguranca = 396;

            //Console.WriteLine(" Dados do primeiro cartão de crédito");
            //System.Console.WriteLine(" Número Cartão de Crédito " + cdc1.numero);
            //System.Console.WriteLine(" Nome no Cartão de Crédito " + cdc1.nome);
            //System.Console.WriteLine(" Data de Validade do Cartão de Crédito " + cdc1.dataDeValidade);
            //System.Console.WriteLine(" Código de segurança do Cartão de Crédito " + cdc1.codigoDeSeguranca);

            //System.Console.WriteLine(" ------------------------------------------ ");

            //System.Console.WriteLine(" Dados do segundo cartão de crédito");
            //System.Console.WriteLine(" Número Cartão de Crédito " + cdc2.numero);
            //System.Console.WriteLine(" Nome no Cartão de Crédito " + cdc2.nome);
            //System.Console.WriteLine(" Data de Validade do Cartão de Crédito " + cdc2.dataDeValidade);
            //System.Console.WriteLine(" Código de segurança do Cartão de Crédito " + cdc2.codigoDeSeguranca);

            //Conta c1 = new Conta();

            //CartaoCredito cdc = new CartaoCredito();
            //Cliente cliente = new Cliente();

            //long cpf = 12345678998;
            //Cliente retorno = cliente.retornaClienteById(cpf);
            //retorno = Michael, 05, 12345678998

            //cdc.cliente = retorno;
            //retorno.nome = "Ana";
            //cdc.numero = 5101353022928113;
            //cdc.cliente.nome = retorno.nome;
            //cdc.dataDeValidade = "27/03/2026";
            //cdc.codigoDeSeguranca = 963;

            //5101353022928113 - Ana - 27 / 03 / 2029 - 963 - 12345678998


            //Console.WriteLine(" Nome " + cdc.cliente.nome);

            //CartaoCredito cdc1 = new CartaoCredito(5101353022928113, "José da Silva", "08/06/2028", 123);
            //CartaoCredito cdc2 = new CartaoCredito(6101353022928110, "Ana", "08/06/2025", 126);
            //CartaoCredito cdc3 = new CartaoCredito(6101353022928125, "Michael", "08/10/2025", 129);
            //cdc1.imprimirResultado();
            //cdc2.imprimirResultado();
            //cdc3.imprimirResultado();

            //Console.WriteLine(" Dados do segundo cartão de crédito");
            //Console.WriteLine(" Número Cartão de Crédito " + cdc1.numero);
            //Console.WriteLine(" Nome no Cartão de Crédito " + cdc1.nome);
            //Console.WriteLine(" Data de Validade do Cartão de Crédito " + cdc1.dataDeValidade);
            //Console.WriteLine(" Código de segurança do Cartão de Crédito " + cdc1.codigoDeSeguranca);


            CartaoCredito cdc1 = new CartaoCredito(5101353022928113);
            cdc1.nome = "José da Silva";
            cdc1.dataDeValidade = "27/03/2026";
            cdc1.codigoDeSeguranca = 963;
            cdc1.imprimirResultado();


        }
    }
}
