using System;
using Task4.Players;

namespace Task4.Bonuses
{
    internal class MedX : Bonus
    {
        public override void BonusEffect(Player player)
        {
            
            player.ShieldDefence += 20;
        }
    }
}
