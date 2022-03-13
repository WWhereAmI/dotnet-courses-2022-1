using Task4.Players;

namespace Task4.Bonuses
{
    internal class Stimulator : Bonus
    {
        public override void BonusEffect(Player player)
        {
            player.HP += 50;
        }

       
    }
}
