﻿using DemoObserver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Patterns.Observers
{
    public abstract class Observer
    {
        public abstract void Update(Subject subject);
    }
}
