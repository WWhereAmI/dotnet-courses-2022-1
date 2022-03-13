using System;
using System.Collections.Generic;

namespace Task4.Enemies
{
    /// <summary>
    /// Ememy descriptor
    /// </summary>
    internal abstract class Enemy : ISubjectActions, ISubjectCharacteristics
    {
        public double HP { get; set; }
        public double Damage { get; set; }
        public double ShieldDefence { get; set; }
        public double Speed { get; set; }

        /// <summary>
        /// Modificator that depends on difficulty level
        /// </summary>
        public static int DifficultyModificator { get; set; }
        /// <summary>
        /// Index of the enemies in the map
        /// </summary>
        public static int EnemyCount { get; set; }
        /// <summary>
        /// Enemy Position
        /// </summary>
        public Coordinates Position { get; set; }

        public abstract void Hit(ISubjectCharacteristics subject);

        public static List<Enemy> EnemiesList { get; set; }

        public void SpawnNPC()
        {
            Random random = new Random();

            Position = new Coordinates
            {
                X = random.Next(0, (int)Board.Map.Width),
                Y = random.Next(0, (int)Board.Map.Height)
            };

            Console.WriteLine($"NPC заспавнен на координатах {Position.X}:{Position.Y}");
        }
        public static void InitialEnemiesList(int enemiesCount)
        {
            Random random = new Random();
            EnemiesList = new List<Enemy>();

            for (int i = 0; i < enemiesCount; i++)
            {
                int randomvalue = random.Next(1, 4);

                switch (randomvalue)
                {
                    case 1:
                        EnemiesList.Add(new Ghoul());
                        break;
                    case 2:
                        EnemiesList.Add(new DeathClaw());
                        break;
                    case 3:
                        EnemiesList.Add(new RadScorpions());
                        break;
                    case 4:
                        EnemiesList.Add(new SuperMutant());
                        break;
                    default:
                        break;
                }
            }
        }

        public void Move()
        {
            Console.WriteLine("Враг двигается на координаты");
        }
    }
}
