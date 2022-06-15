using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class TesteCliente
    {
        public static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Michael Tadeu";
            cliente1.codigo = 1;

            Cliente cliente2 = new Cliente();
            cliente2.nome = "Daniel";
            cliente2.codigo = 2;

            Cliente cliente3 = new Cliente();
            cliente3.nome = "Lais";
            cliente3.codigo = 3;

            //cliente3.validaCPF("398.693.569-89");

            System.Console.WriteLine(" Dados do primeiro Cliente ");
            System.Console.WriteLine(" Nome: " + cliente1.nome);
            System.Console.WriteLine(" Código: " + cliente1.codigo);

            System.Console.WriteLine(" Dados do segundo Cliente ");
            System.Console.WriteLine(" Nome: " + cliente2.nome);
            System.Console.WriteLine(" Código: " + cliente2.codigo);

            System.Console.WriteLine(" Dados do terceiro Cliente ");
            System.Console.WriteLine(" Nome: " + cliente3.nome);
            System.Console.WriteLine(" Código: " + cliente3.codigo);

        }
    }
}
