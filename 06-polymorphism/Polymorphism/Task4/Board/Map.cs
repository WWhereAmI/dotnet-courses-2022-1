using System.Collections.Generic;
using Task4.Bonuses;
using Task4.Difficulty;
using Task4.Enemies;
using Task4.Players;

namespace Task4.Board
{
    internal class Map
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public List<Bonus> BonusList { get; set; }
        public List<Enemy> EnemiesList { get; set; }
        public List<MapObjects> MapObjectsList { get; set; }
        public Player CurrentPlayer { get; set; }
        public GameDifficulty Difficulty { get; set; }

        public Map(GameDifficulty difficulty, Player newPlayer)
        {
            InitialObjects();
            InitialEnemies();
            InitialBonuses();
            BonusList = Bonus.BonusList;
            EnemiesList = Enemy.EnemiesList;
            MapObjectsList = MapObjects.MapObjectsList;

            Difficulty = difficulty;
            CurrentPlayer = newPlayer;

            newPlayer.SpawnHero();
        }

        private void InitialObjects()
        {
            foreach (var obj in MapObjects.MapObjectsList)
            {
                obj.GenerateObject();
            }
        }

        private void InitialEnemies()
        {
            foreach (var npc in Enemy.EnemiesList)
            {
                npc.SpawnNPC();
            }
        }

        private void InitialBonuses()
        {
            foreach (var bonus in Bonus.BonusList)
            {
                bonus.GenerateBonus();
            }
        }


    }
}
