namespace Task4.Difficulty
{
    internal class Hard : GameDifficulty
    {
        public Hard()
        {
            Board.Map.Width = 1500;
            Board.Map.Height = 1500;

            Bonuses.Bonus.BonusCount = 20;
            Enemies.Enemy.EnemyCount = 15;

            Enemies.Enemy.DifficultyModificator = 3;

            Board.MapObjects.InitialObjectList(9);
            Enemies.Enemy.InitialEnemiesList(Enemies.Enemy.EnemyCount);
            Bonuses.Bonus.InitialBonusList(Bonuses.Bonus.BonusCount);
        }
    }
}
