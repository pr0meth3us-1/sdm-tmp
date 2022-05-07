namespace ZombieGame.Hunter
{
    using System;

    using ZombieGame.Zombie;

    public class Hunter : IHunter
    {
        public void Update(ZombieEvent zombieEvent)
        {
            switch (zombieEvent.EventType)
            {
                case ZombieEventType.EnteredMap:
                    Console.WriteLine($"Zombie entered map. Last known position: {zombieEvent.Zombie.Position}");
                    break;
                case ZombieEventType.LeavedMap:
                    Console.WriteLine($"Zombie leaved map. Last known position: {zombieEvent.Zombie.Position}");
                    break;
            }
        }
    }
}