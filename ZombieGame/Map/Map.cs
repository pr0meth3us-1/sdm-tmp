namespace ZombieGame.Map
{
    using System.Collections.Generic;

    using ZombieGame.Zombie;

    public class Map : IMap
    {
        public IList<IObserver<ZombieEvent>> Observers { get; } = new List<IObserver<ZombieEvent>>();

        public IList<IZombie> Zombies { get; } = new List<IZombie>();

        public void AddZombie(IZombie zombie)
        {
            this.Zombies.Add(zombie);

            var zombieEvent = new ZombieEvent(zombie, ZombieEventType.EnteredMap);

            this.Notify(zombieEvent);
        }

        public void Attach(IObserver<ZombieEvent> observer)
        {
            this.Observers.Add(observer);
        }

        public void Detach(IObserver<ZombieEvent> observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify(ZombieEvent zombieEvent)
        {
            foreach (var observer in this.Observers)
            {
                observer.Update(zombieEvent);
            }
        }

        public void RemoveZombie(IZombie zombie)
        {
            this.Zombies.Remove(zombie);

            var zombieEvent = new ZombieEvent(zombie, ZombieEventType.LeavedMap);

            this.Notify(zombieEvent);
        }
    }
}