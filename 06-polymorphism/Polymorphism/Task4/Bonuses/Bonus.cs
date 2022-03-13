using System;
using System.Collections.Generic;
using Task4.Players;
using Task4.Board;

namespace Task4.Bonuses
{
    abstract internal class Bonus
    {
        public static int BonusCount { get; set; }
        abstract public void BonusEffect(Player player);
        
        public Coordinates Position { get; set; }

        public void GenerateBonus()
        {
            Random random = new Random();

            Position = new Coordinates
            {
                X = random.Next(0, (int)Map.Width),
                Y = random.Next(0, (int)Map.Height)
            };

            Console.WriteLine($"Бонус создан на координатах {Position.X}:{Position.Y}");
        }

        public static List<Bonus> BonusList { get; set; }

        public static void InitialBonusList(int objectsCount)
        {
            Random random = new Random();
            BonusList = new List<Bonus>();

            for (int i = 0; i < objectsCount; i++)
            {
                int randomvalue = random.Next(1, 3);

                switch (randomvalue)
                {
                    case 1:
                        BonusList.Add(new MedX());
                        break;
                    case 2:
                        BonusList.Add(new Psycho());
                        break;
                    case 3:
                        BonusList.Add(new Stimulator());
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
