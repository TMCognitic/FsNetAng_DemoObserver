﻿using DemoObserver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Patterns.Observers
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}