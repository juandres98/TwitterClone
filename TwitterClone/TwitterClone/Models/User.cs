﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
