// Game.cs

using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          Map map = new Map(8, 5);
          
          try 
          {
            MapLocation mapLocation = new MapLocation(20, 20, map);
          }
          catch(Exception ex)
          {
            Console.WriteLine(ex.Message);  // 20, 20 is outside the boundaries of the map.
          }
        }
    }
}



// MapLocations.cs

namespace TreehouseDefense
{
 class MapLocation : Point
 {
   public MapLocation(int x, int y, Map map) : base(x, y)
   {
     if (!map.OnMap(this))
     {
         throw new System.Exception(x + "," + y + " is outside the boundaries of the map.");
     }
   }
 }
}