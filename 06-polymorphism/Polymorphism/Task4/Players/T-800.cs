using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Players
{
    internal class T_800 : Player
    {
        public override void Hit(ISubjectCharacteristics subject)
        {
            if (subject.HP > HP)
            {
                subject.HP -= (Damage * 2 - ShieldDefence);
            }
            else
            {
                subject.HP -= (Damage - subject.ShieldDefence);
            }
        }

        public T_800()
        {
            HP = 400;
            Damage = 100;
            ShieldDefence = 100;
            Speed = 2;
        }
    }
}
