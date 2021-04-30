﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //setting the default value for properties
        public int Age { get; set; } = 0;

        //setting the default value for properties
        public bool IsAlive { get; set; } = true;
    }
}