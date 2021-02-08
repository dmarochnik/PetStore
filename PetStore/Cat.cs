using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    class Cat : Animal, IGroomed
    {
        private static readonly string TYPE = "Cat";

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

        private bool _has_fvrcp_vax;
        public bool Has_fvrcp_vax
        {
            get
            {
                return _has_fvrcp_vax;
            }
            set
            {
                _has_fvrcp_vax = value;
            }
        }
        private bool _has_felv_vax;
        public bool Has_felv_vax
        {
            get
            {
                return _has_felv_vax;
            }
            set
            {
                _has_felv_vax = value;
            }
        }


        public Cat(string species, string name, string breed, DateTime birthdate, decimal price, DateTime groomdate, bool has_fvrcp_vax, bool has_felv_vax)
            :base(TYPE, species, name, breed, birthdate, price)
        {
            _species = species;
            _name = name;
            _breed = breed;
            _birthdate = birthdate;
            _price = price;
            _groomDate = groomdate;
            _has_fvrcp_vax = has_fvrcp_vax;
            _has_felv_vax = has_felv_vax;
        }

        public string GiveIntro()
        {
            var today = DateTime.Today;
            var age = today.Year - _birthdate.Year;
            string intro = "My name is " + _name + ", I am a " + _breed + " cat, and I am " + age + " years old.";
            return intro;
        }

        public string GiveFVRCPstatus()
        {
            string status = "";
            if(_has_fvrcp_vax == true)
            {
                status = _name + " is vaccinated.";
            }
            else
            {
                status = _name + " is not vaccinated.";
            }
            return status;
        }

        public bool IsGroomed()
        {
            bool isGroomed = false;
            DateTime now = DateTime.Now;
            int timeSinceGrooming = now.Year - GroomDate.Year;

            if (now.Month < GroomDate.Month || (now.Month == GroomDate.Month && now.Day < GroomDate.Day))
                timeSinceGrooming--;

            if (timeSinceGrooming < 2)
            {
                isGroomed = true;
            }
            return isGroomed;
        }
    }
}
