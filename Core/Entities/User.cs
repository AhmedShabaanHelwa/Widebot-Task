﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class User : EntityBase
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }
}