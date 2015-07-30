﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformIT.Domain
{
    public class Session
    {
        public Session(string title, string @abstract, Speaker speaker)
        {
            Title = title;
            Abstract = @abstract;
            Speaker = speaker;
        }

        public string Title { get; private set; }
        public string Abstract { get; private set; }
        public Speaker Speaker { get; private set; }
    }
}