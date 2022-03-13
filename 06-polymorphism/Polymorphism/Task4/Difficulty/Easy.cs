namespace Task4.Difficulty
{
    internal class Easy : GameDifficulty
    {
        public Easy()
        {
            Board.Map.Width = 500;
            Board.Map.Height = 500;

            Bonuses.Bonus.BonusCount = 10;
            Enemies.Enemy.EnemyCount = 5;

            Enemies.Enemy.DifficultyModificator = 1;

            Board.MapObjects.InitialObjectList(5);
            Enemies.Enemy.InitialEnemiesList(Enemies.Enemy.EnemyCount);
            Bonuses.Bonus.InitialBonusList(Bonuses.Bonus.BonusCount);
        }




    }
}
