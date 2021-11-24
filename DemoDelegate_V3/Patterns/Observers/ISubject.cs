namespace DemoObserver.Patterns.Observers
{
    public interface ISubject
    {
        event Action<ISubject>? OnNotify;
    }
}