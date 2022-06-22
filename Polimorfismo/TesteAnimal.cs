using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class TesteAnimal
    {

        public static void Main(string[] args)
        {
            ////Chamada Herança
            //Peixe peixe = new Peixe("Piau");
            //peixe.mover();

            ////Chamada Polimorfismo
            //Animal vetor[] animais;
            //animais[i].mover();

            string tipo = "Macaco";
            string especie = "Mico";

            Animal[] animal = new Animal[3];

            //Exemplo com regra
            //if (tipo == "Macaco")
            //{
            //    animal[0] = new Macaco(especie);
            //} else if (tipo == "Peixe")
            //{
            //    animal[1] = new Peixe(especie);
            //}


            animal[0] = new Peixe("Carpa");
            animal[1] = new Macaco("Mico");
            animal[2] = new Ave("Pombo");

            moverAnimal(animal[1]);
            Console.ReadKey();
            
        }

        public static void moverAnimal(Animal animal)
        {
            Console.WriteLine(animal.tipo);
            animal.mover(); //macaco.mover()

        }

    }
}
