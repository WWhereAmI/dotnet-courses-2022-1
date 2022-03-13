using System;
using System.Collections.Generic;

namespace Task4.Board
{
    internal abstract class MapObjects
    {
        public abstract double Width { get; set; }
        public abstract double Height { get; set; }
        public Coordinates Position { get; set; }

        public void GenerateObject()
        {
            Random random = new Random();

            Position = new Coordinates
            {
                X = random.Next(0, (int)Map.Width),
                Y = random.Next(0, (int)Map.Height)
            };

            Console.WriteLine($"Объет создан на координатах {Position.X}:{Position.Y}");
        }

        public static List<MapObjects> MapObjectsList { get; set; }

        public static void InitialObjectList(int objectsCount)
        {
            Random random = new Random();
            MapObjectsList = new List<MapObjects>();

            for (int i = 0; i < objectsCount; i++)
            {
                int randomvalue = random.Next(1, 3);

                switch (randomvalue)
                {
                    case 1:
                        MapObjectsList.Add(new River());
                        break;
                    case 2:
                        MapObjectsList.Add(new Rock());
                        break;
                    case 3:
                        MapObjectsList.Add(new Tree());
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
