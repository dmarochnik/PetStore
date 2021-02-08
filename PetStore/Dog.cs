using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    class Dog : Animal, IGroomed
    {
        private static readonly string TYPE = "Dog";

        private DateTime _groomDate;
        public DateTime GroomDate
        {
            get
            {
                return _groomDate;
            }
            set
            {
                _groomDate = value;
            }
        }

        private bool _hasDapVax;
        public bool HasDapVax
        {
            get
            {
                return _hasDapVax;
            }
            set
            {
                _hasDapVax = value;
            }
        }
        private bool _hasRabiesVax;
        public bool HasRabiesVax
        {
            get
            {
                return _hasRabiesVax;
            }
            set
            {
                _hasRabiesVax = value;
            }
        }

        public Dog(string species, string name, string breed, DateTime birthdate, decimal price, DateTime groomdate, bool hasDapVax, bool hasRabiesVax)
            :base(TYPE, species, name, breed, birthdate, price)
        {
            _species = species;
            _name = name;
            _breed = breed;
            _birthdate = birthdate;
            _price = price;
            _groomDate = groomdate;
            _hasDapVax = hasDapVax;
            _hasRabiesVax = hasRabiesVax;
        }

        public string GiveIntro()
        {
            var today = DateTime.Today;
            var age = today.Year - _birthdate.Year;
            string intro = "My name is " + _name + ", I am a " + _breed + " dog, and I am " + age + " years old.";
            return intro;
        }

        public bool IsGroomed()
        {
            bool isGroomed = false;
            DateTime now = DateTime.Now;
            int timeSinceGrooming = now.Year - GroomDate.Year;

            if (now.Month < GroomDate.Month || (now.Month == GroomDate.Month && now.Day < GroomDate.Day))
                timeSinceGrooming--;

            if (timeSinceGrooming < 1)
            {
                isGroomed = true;
            }
            return isGroomed;
        }
    }
}
