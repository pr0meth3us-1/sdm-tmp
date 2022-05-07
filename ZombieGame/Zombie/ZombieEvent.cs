namespace ZombieGame.Zombie
{
    public class ZombieEvent
    {
        public IZombie Zombie { get; set; }

        public ZombieEventType EventType { get; set; }

        public ZombieEvent(IZombie zombie, ZombieEventType eventType)
        {
            this.Zombie = zombie;
            this.EventType = eventType;
        }
    }

    public enum ZombieEventType
    {
        EnteredMap,
        LeavedMap
    }
}