﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    public abstract class Observer
    {
        public abstract void Update(string info);
    }
}
