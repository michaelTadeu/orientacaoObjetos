using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class ControlePonto
    {
        public void registraEntrada(Gerente gerente)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0:d/M/yyyy HH:mm:ss", agora);

            Console.WriteLine("Entrada: " + gerente.codigo);
            Console.WriteLine("Data: " + horario);
        }

        public void registrarSaida(Gerente gerente)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0:d/M/yyyy HH:mm:ss", agora);

            Console.WriteLine("Saída: " + gerente.codigo);
            Console.WriteLine("Data: "+ horario);
        }

        public void registraEntrada(Telefonista telefonista)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0:d/M/yyyy HH:mm:ss", agora);

            Console.WriteLine("Entrada: " + telefonista.codigo);
            Console.WriteLine("Data: " + horario);
        }

        public void registrarSaida(Telefonista telefonista)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0:d/M/yyyy HH:mm:ss}", agora);

            Console.WriteLine("Saída: " + telefonista.codigo);
            Console.WriteLine("Data: " + horario);
        }



        public void registraEntrada(Funcionario func)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

            Console.WriteLine("Entrada: " + func.codigo);
            Console.WriteLine("Data: " + horario);
        }

        public void registrarSaida(Funcionario func)
        {
            DateTime agora = DateTime.Now;
            string horario = String.Format(" {0:d/M/yyyy HH:mm:ss}", agora);

            Console.WriteLine("Saída: " + func.codigo);
            Console.WriteLine("Data: " + horario);
        }



    }
}
