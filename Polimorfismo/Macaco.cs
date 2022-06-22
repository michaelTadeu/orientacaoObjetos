using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Macaco : Animal
    {
        public Macaco(string tipoAnimal) : base(tipoAnimal)
        {

        }

        public override void mover()
        {
            Console.WriteLine("Macaco anda 10mts");
        }
    }
}
