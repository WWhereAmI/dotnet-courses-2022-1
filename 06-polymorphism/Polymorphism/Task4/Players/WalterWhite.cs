using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Players
{
    internal class WalterWhite : Player
    {

        public override void Hit(ISubjectCharacteristics subject)
        {
            subject.ShieldDefence -= 5;
            subject.HP -= (Damage * 2 - subject.ShieldDefence);                  
        }

        public WalterWhite()
        {
            HP = 200;
            Damage = 40;
            ShieldDefence = 40;
            Speed = 10;
        }
    }
}
