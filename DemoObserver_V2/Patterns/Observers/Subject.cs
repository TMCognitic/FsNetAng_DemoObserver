using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Patterns.Observers
{
    public class Subject : ISubject
    {
        private Action<ISubject>? _onNotify;

        public void Attach(Action<ISubject> method)
        {
            _onNotify += method;
        }

        public void Detach(Action<ISubject> method)
        {
            _onNotify -= method;
        }

        protected void Notify()
        {
            _onNotify?.Invoke(this);
        }
    }
}
