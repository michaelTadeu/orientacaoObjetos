using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Peixe : Animal
    {
        public Peixe(string tipoAnimal) : base(tipoAnimal)
        {

        }

        public override void mover()
        {
            Console.WriteLine("Peixe nada 10mts");
        }

    }
}
