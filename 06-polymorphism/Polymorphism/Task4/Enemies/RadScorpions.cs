namespace Task4.Enemies
{
    internal class RadScorpions : Enemy
    {
        public RadScorpions()
        {
            HP = 100 * DifficultyModificator;
            Damage = 15 * DifficultyModificator;
            ShieldDefence = 0 * DifficultyModificator;
            Speed = 3;

            EnemiesList.Add(this);
        }

        public override void Hit(ISubjectCharacteristics subject)
        {
            subject.HP -= (Damage - subject.ShieldDefence);
        }
    }
}
