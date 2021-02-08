using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    interface IGroomed
    {
        DateTime GroomDate { get; set; }

        public bool IsGroomed();

    }
}
