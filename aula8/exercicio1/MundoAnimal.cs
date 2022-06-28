using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class MundoAnimal
    {

        public List<Animal> animais = new List<Animal>();
        

        public MundoAnimal()
        {
            animais = new List<Animal>();
        }

       

        public bool inserir(Animal animal)
        {
            animais.Add(new Animal() {Nome = "elefante", Ambiente="selva", Cor="cinza",
            VelocidadeMedia=12.0, NumeroPatas=4}); 

        }
    }   
}
