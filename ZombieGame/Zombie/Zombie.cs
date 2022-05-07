namespace ZombieGame.Zombie
{
    using System.Numerics;

    public class Zombie : IZombie
    {
        public Zombie(Vector3 position)
        {
            this.Position = position;
        }

        public Vector3 Position { get; set; }

        public void Move(Vector3 position)
        {
            this.Position = position;
        }
    }
}