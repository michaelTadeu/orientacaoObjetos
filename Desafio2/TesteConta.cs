using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class TesteConta
    {
        public static void Main(string[] args)
        {
            //Conta c1 = new Conta();

            //double pSaldo = 63;

            //c1.Deposito(63);

            //Console.WriteLine(" Limite:  " + c1.limite);

            //Conta c1 = new Conta();
            //c1.numero = 1234;
            //c1.saldo = 10000;
            //c1.limite = 500;

            //Conta c2 = new Conta();
            //c2.numero = 5678;
            //c2.saldo = 12000;
            //c2.limite = 500;

            //System.Console.WriteLine(" Dados da primeira conta ");
            //System.Console.WriteLine(" Número da Conta: " + c1.numero);
            //System.Console.WriteLine(" Saldo da Conta: " + c1.saldo);
            //System.Console.WriteLine(" Limite da Conta: " + c1.limite);

            //System.Console.WriteLine(" ------------------ ");

            //System.Console.WriteLine(" Dados da segunda conta ");
            //System.Console.WriteLine(" Número da Conta: " + c2.numero);
            //System.Console.WriteLine(" Saldo da Conta: " + c2.saldo);
            //System.Console.WriteLine(" Limite da Conta: " + c2.limite);

            Conta c1 = new Conta(new Agencia(123));
            //c1.numero = 1234;
            c1.saldo = 10000;
            c1.limite = 500;
            c1.Deposito(200);
            Console.WriteLine(" Número da Conta: " + c1.numero);
            Console.WriteLine(" Saldo da Conta: " + c1.saldo);
            Console.WriteLine(" Limite da Conta: " + c1.limite);

        }
    }
}
