﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP.Web.Entities
{
    public class Profile
    {
        public int ProfileId { get; set; }

        public string LookingFor { get; set; }
        public string Introduction { get; set; }
        public string Pitch { get; set; }

        // Relationship from Profile to Member
        public Member Member { get; set; }

        // Relationship from Profile to Demographics
        public Demographics Demographics { get; set; }
    }
}
