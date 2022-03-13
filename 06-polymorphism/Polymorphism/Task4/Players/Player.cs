using System;
using Task4.Bonuses;

namespace Task4.Players
{
    internal abstract class Player : ISubjectActions, ISubjectCharacteristics
    {    
        public double HP { get; set; }
        public double Damage { get; set; }
        public double ShieldDefence { get; set; }
        public double Speed { get; set; }

        public Coordinates Position { get; set; }

        public abstract void Hit(ISubjectCharacteristics subject);

        public void SpawnHero()
        {
            Random random = new Random();

            Position = new Coordinates
            {
                X = random.Next(0, (int)Board.Map.Width),
                Y = random.Next(0, (int)Board.Map.Height)
            };

            Console.WriteLine($"Герой заспавнен на координатах {Position.X}:{Position.Y}");
        }

        public void TakeBonus(Bonus bonus)
        {
            bonus.BonusEffect(this);
            Bonus.BonusList.Remove(bonus);
            Bonus.BonusCount--;
        }

        public void Move()
        {
            Console.WriteLine("Игрок начал движение");
        }
    }
}
