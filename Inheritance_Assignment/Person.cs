﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Person
    {
        public string FirstName = "Rita";
        public string LastName = "Krasnauska";

        public void SayName()
        {
            Console.WriteLine("Name:" + FirstName + " " + LastName);

        }

    }
}
