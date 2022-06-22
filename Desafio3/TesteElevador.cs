using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class TesteElevador
    {
        public static void Main(string[] args)
        {
            Elevador elevador = new Elevador(10, 13);

            elevador.Entrar(7);
            elevador.Sair(2);
            elevador.Sair(7);

            elevador.Entrar(6);
            elevador.Entrar(5);

            elevador.Deslocar(10);
            elevador.Deslocar(15);
            elevador.Deslocar(20);

            elevador.Subir(2);
            elevador.Descer(10);
            elevador.Descer(10);
            elevador.Descer(2);
        }
    }        
}
