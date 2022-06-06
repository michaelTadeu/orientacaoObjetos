using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1OrientacaoAObjetos
{
    class TestaAluno
    {
        public static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();

            a1.Nome = "João Pedro";
            a1.DataNascimento = DateTime.Now;
            a1.RG = "55.206.123-0";

            a2.Nome = "Rafael Augusto";
            a2.DataNascimento = DateTime.Now.AddMonths(-3);
            a2.RG = "21.255.123-0";

            Console.WriteLine("aluno 1:");
            Console.WriteLine($"Nome: {a1.Nome}");
            Console.WriteLine($"Data de Nascimento: {a1.DataNascimento}");
            Console.WriteLine($"RG: {a1.RG}");
            Console.WriteLine("aluno 2:");
            Console.WriteLine($"Nome: {a2.Nome}");
            Console.WriteLine($"Data de Nascimento: {a2.DataNascimento}");
            Console.WriteLine($"RG: {a2.RG}");
        }
    }
}
