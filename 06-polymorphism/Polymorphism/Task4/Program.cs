using System;
using Task4.Board;
using Task4.Enemies;
using Task4.Difficulty;
using Task4.Players;
using Task4.Bonuses;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(new Easy(),new T_800());

            map.CurrentPlayer.Hit(map.EnemiesList[1]);
            map.CurrentPlayer.Move();
            map.CurrentPlayer.TakeBonus(map.BonusList[1]);
        }
    }
}
