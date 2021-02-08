using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    public class Lizard : Animal
    {
        private static readonly string TYPE = "Lizard";

        public Lizard(string species, string name, string breed, DateTime birthdate, decimal price, DateTime groomdate, bool hasDapVax, bool hasRabiesVax)
            :base(TYPE, species, name, breed, birthdate, price)
        {
            _species = species;
            _name = name;
            _breed = breed;
            _birthdate = birthdate;
            _price = price;
        }

        public string GiveIntro()
        {
            var today = DateTime.Today;
            var age = today.Year - _birthdate.Year;
            string intro = "My name is " + _name + ", I am a " + TYPE + ", and I am " + age + " years old.";
            return intro;
        }
    }
}
