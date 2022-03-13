namespace Task4.Enemies
{
    internal class DeathClaw : Enemy
    {     
        public DeathClaw()
        {
            HP = 1000 * DifficultyModificator;
            Damage = 100 * DifficultyModificator;
            ShieldDefence = 0 * DifficultyModificator;
            Speed = 0.5;

            EnemiesList.Add(this);
        }

        public override void Hit(ISubjectCharacteristics subject)
        {
            subject.HP -= (Damage - subject.ShieldDefence);
        }


    }
}
