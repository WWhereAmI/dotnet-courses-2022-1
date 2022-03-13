using Task4.Players;

namespace Task4.Bonuses
{
    internal class Psycho : Bonus
    {
        public override void BonusEffect(Player player)
        {
            player.Speed += 2;
        }
    }
}
