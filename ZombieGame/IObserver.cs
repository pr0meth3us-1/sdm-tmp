namespace ZombieGame
{
    public interface IObserver<in T>
    {
        void Update(T obj);
    }
}