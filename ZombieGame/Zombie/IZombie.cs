namespace ZombieGame.Zombie
{
    using System.Numerics;

    public interface IZombie
    {
        Vector3 Position { get; set; }

        void Move(Vector3 position);
    }
}