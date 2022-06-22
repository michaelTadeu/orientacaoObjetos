using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class TesteAgencia
    {
        public static void Main(string[] args)
        {
            Agencia a1 = new Agencia(6889);
            Agencia a2 = new Agencia(5874);

            System.Console.WriteLine(" Dados da primeira agência ");
            System.Console.WriteLine(" Número da agência " + a1.numero);

            System.Console.WriteLine(" ---------------- ");

            System.Console.WriteLine(" Dados da segunda agência ");
            System.Console.WriteLine(" Número da agência " + a2.numero);

        }

    }
}
