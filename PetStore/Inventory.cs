using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore
{
    class Inventory
    {
        public List<Animal> _animals;

        public Inventory()
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public List<Animal> GetInventory()
        {
            List<Animal> inventory = new List<Animal>();
            foreach(Animal animal in _animals)
            {
                inventory.Add(animal);
            }
            return inventory;
        }

        public List<IGroomed> IsGroomed()
        {
            List<IGroomed> ig = new List<IGroomed>();

            foreach (Animal animal in _animals)
            {
               if (animal is IGroomed)
                {
                    ig.Add(animal as IGroomed);
                }
            }

            return ig;
            
        }

    }
}
