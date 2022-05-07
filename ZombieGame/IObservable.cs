namespace ZombieGame
{
    using System.Collections.Generic;

    public interface IObservable<T>
        where T : class
    {
        IList<IObserver<T>> Observers { get; }

        void Attach(IObserver<T> observer);

        void Detach(IObserver<T> observer);

        void Notify(T obj);
    }
}