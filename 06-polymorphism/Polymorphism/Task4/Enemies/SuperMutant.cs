namespace Task4.Enemies
{
    internal class SuperMutant : Enemy
    {
        public SuperMutant()
        {
            HP = 250 * DifficultyModificator;
            Damage = 40 * DifficultyModificator;
            ShieldDefence = 30 * DifficultyModificator;
            Speed = 2;

            EnemiesList.Add(this);
        }

        public override void Hit(ISubjectCharacteristics subject)
        {
            subject.HP -= (Damage - subject.ShieldDefence);
        }
    }
}
