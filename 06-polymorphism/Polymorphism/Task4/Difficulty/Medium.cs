namespace Task4.Difficulty
{
    internal class Medium : GameDifficulty
    {
        public Medium()
        {

            Board.Map.Width = 500;
            Board.Map.Height = 1500;


            Bonuses.Bonus.BonusCount = 15;
            Enemies.Enemy.EnemyCount = 10;

            Enemies.Enemy.DifficultyModificator = 2;

            Board.MapObjects.InitialObjectList(7);
            Enemies.Enemy.InitialEnemiesList(Enemies.Enemy.EnemyCount);
            Bonuses.Bonus.InitialBonusList(Bonuses.Bonus.BonusCount);

        }
    }
}
