﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08.Entities
{
    public class BallFactory : ToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
