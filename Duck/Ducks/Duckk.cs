﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public abstract class Duckk
    {
        public string swim()
        {
            return "swim " + this.GetType();
        }
        abstract public string display();
    }
}