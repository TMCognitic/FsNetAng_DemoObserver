using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Patterns.Observers
{
    public class Subject : ISubject
    {
        public event Action<ISubject>? OnNotify;

        protected void Notify()
        {
            OnNotify?.Invoke(this);
        }
    }
}
