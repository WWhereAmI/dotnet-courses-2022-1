namespace Task4.Players
{
    internal class GeraltFromRivia : Player
    { 

        public override void Hit(ISubjectCharacteristics subject)
        {
            if (subject.HP < subject.HP / 2)
            {
                subject.HP = 0;
            }
            else
            {
                subject.HP -= (Damage - subject.ShieldDefence);
            }          
        }

        public GeraltFromRivia()
        {
            HP = 350;
            Damage = 50;
            ShieldDefence = 30;
            Speed = 4;
        }




    }
}
