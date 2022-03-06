﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohde.Assessment
{
    public abstract class Mammal : aMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetDetails()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }
}
        

