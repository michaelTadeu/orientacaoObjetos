using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class TesteConta
    {
        public static void Main(string[] args)
        {
            Conta c1 = new Conta();
            c1.numero = 1234;
            c1.saldo = 10000;
            c1.limite = 500;

            Conta c2 = new Conta();
            c2.numero = 5678;
            c2.saldo = 12000;
            c2.limite = 500;

            System.Console.WriteLine(" Dados da primeira conta ");
            System.Console.WriteLine(" Número da Conta: " + c1.numero);
            System.Console.WriteLine(" Saldo da Conta: " + c1.saldo);
            System.Console.WriteLine(" Limite da Conta: " + c1.limite);

            System.Console.WriteLine(" ------------------ ");

            System.Console.WriteLine(" Dados da segunda conta ");
            System.Console.WriteLine(" Número da Conta: " + c2.numero);
            System.Console.WriteLine(" Saldo da Conta: " + c2.saldo);
            System.Console.WriteLine(" Limite da Conta: " + c2.limite);






        }
    }
}
