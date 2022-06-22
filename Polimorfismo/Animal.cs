using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Animal
    {
        public string tipo;

        public Animal(string tipoAnimal)
        {
            this.tipo = tipoAnimal;
        }

        public virtual void mover()
        {
            Console.WriteLine("Animal anda 10mts");
        }
    }
}
