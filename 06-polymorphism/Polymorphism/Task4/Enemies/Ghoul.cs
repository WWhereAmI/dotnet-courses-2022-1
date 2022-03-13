namespace Task4.Enemies
{
    internal class Ghoul : Enemy
    {      
        public Ghoul()
        {
            HP = 200 * DifficultyModificator;
            Damage = 30 * DifficultyModificator;
            ShieldDefence = 15 * DifficultyModificator;
            Speed = 3;

            EnemiesList.Add(this);
        }

        public override void Hit(ISubjectCharacteristics subject)
        {
            subject.HP -= (Damage - subject.ShieldDefence);
        }
    }
}
