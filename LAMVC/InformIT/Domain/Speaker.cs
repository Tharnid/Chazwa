﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformIT.Domain
{
    public class Speaker
    {
        public Speaker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Bio { get; set; }
    }
}