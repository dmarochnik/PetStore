using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    public abstract class Animal
    {
        protected string _type;
        public string Type
        {
            get
            {
                return _type;
            }
        }
        protected string _species;
        public string Species
        {
            get
            {
                return _species;
            }
        }

        protected string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        protected string _breed;
        public string Breed
        {
            get
            {
                return _breed;
            }
        }
        protected DateTime _birthdate;
        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }
        }
        protected decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public Animal (string type, string species, string name, string breed, DateTime birthdate, decimal price)
        {
            _type = type;
            _species = species;
            _name = name;
            _breed = breed;
            _birthdate = birthdate;
            _price = price;
        }

    }
}
