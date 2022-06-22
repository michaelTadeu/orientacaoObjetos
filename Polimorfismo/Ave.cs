using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Ave : Animal
    {
        public Ave(string tipoAnimal) : base(tipoAnimal)
        {
            
        }

        public override void mover()
        {
            Console.WriteLine("Ave voa 10mts");
        }
    }
}
