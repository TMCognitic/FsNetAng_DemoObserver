namespace DemoObserver.Patterns.Observers
{
    public interface ISubject
    {
        void Attach(Action<ISubject> method);
        void Detach(Action<ISubject> method);
    }
}