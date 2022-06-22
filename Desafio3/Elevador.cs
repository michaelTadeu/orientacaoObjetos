using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class Elevador
    {
        private int andarAtual;
        public int totalAndares { get; set; }
        public int capacidade { get; set; }
        private int pessoasPresentes;

        public Elevador(int capacidade, int totalAndares)
        {
            this.capacidade = capacidade;
            this.totalAndares = totalAndares;
            this.andarAtual = 0;
            this.pessoasPresentes = 0;
        }

        public void Entrar(int quantidade)
        {
            if (pessoasPresentes + quantidade > capacidade)
            {
                Console.WriteLine($"\nNão é possível entrar {quantidade} pessoas!");
                Console.WriteLine($"\nPessoas no elevador: { pessoasPresentes } pessoas");
                Console.WriteLine($"Capacidade máxima: { capacidade } pessoas");
            }
            else
            {
                pessoasPresentes += quantidade;
                Console.WriteLine($"\nPessoas no elevador: { pessoasPresentes } pessoas");
                Console.WriteLine($"Capacidade máxima: { capacidade } pessoas");
            }
        }

        public void Sair(int quantidade)
        {
            if (quantidade > pessoasPresentes)
            {
                Console.WriteLine($"\nNão existe esse número ({quantidade}) de pessoas para sair!");
                Console.WriteLine($"\nPessoas no elevador: { pessoasPresentes } pessoas");
                Console.WriteLine($"Capacidade máxima: { capacidade } pessoas");
            }
            else
            {
                pessoasPresentes -= quantidade;
                Console.WriteLine($"\nPessoas no elevador: { pessoasPresentes } pessoas");
                Console.WriteLine($"Capacidade máxima: { capacidade } pessoas");
            }
        }

        public void Subir(int qtdSubir)
        {
            int andarDesejado = andarAtual + qtdSubir;
            if (andarDesejado > totalAndares)
            {
                Console.WriteLine($"\nJá estamos no último andar!");
            }
            else
            {
                andarAtual += qtdSubir;
                Console.WriteLine($"\nAndar atual: { andarAtual }");
                Console.WriteLine($"Último andar: { totalAndares }");
            }
        }
        public void Descer(int qtdDescer)
        {
            int andarDesejado = andarAtual - qtdDescer;
            if (andarDesejado < 0)
            {
                Console.WriteLine($"\nJá estamos no primeiro andar!");
            }
            else
            {
                andarAtual -= qtdDescer;
                Console.WriteLine($"\nAndar atual: { andarAtual }");
                Console.WriteLine($"Último andar: { totalAndares }");
            }
        }

        public void Deslocar(int andarDesejado)
        {
            if (andarDesejado > andarAtual)
            {
                Subir(andarDesejado - andarAtual);
            }
            else
            {
                Descer(andarAtual - andarDesejado);
            }
        }
    }
}
