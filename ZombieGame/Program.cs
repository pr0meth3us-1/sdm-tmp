namespace ZombieGame
{
    using System;
    using System.Numerics;
    using System.Threading;

    internal class Program
    {
        public static Vector3 GetRandomVector(Random random)
        {
            return new Vector3(random.Next(100), random.Next(20), random.Next(30));
        }

        static void Main(string[] args)
        {
            var map = new Map.Map();
            var hunter = new Hunter.Hunter();

            map.Attach(hunter);

            var random = new Random((int) DateTime.UtcNow.Ticks);
            var numZombies = random.Next(50);

            for (var i = 0; i < numZombies; i++)
            {
                var position = GetRandomVector(random);
                var zombie = new Zombie.Zombie(position);

                map.AddZombie(zombie);

                Thread.Sleep(random.Next(200));

                zombie.Move(GetRandomVector(random));

                Thread.Sleep(random.Next(200));

                map.RemoveZombie(zombie);
            }

            map.Detach(hunter);
        }
    }
}