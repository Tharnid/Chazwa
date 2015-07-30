using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformIT.Models
{
    public class ConferenceListModel
    {
        public string Name { get; set; }
        public int SessionCount { get; set; }
        public int AttendeeCount { get; set; }
    }
}