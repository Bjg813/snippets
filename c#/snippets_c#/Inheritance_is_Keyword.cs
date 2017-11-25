/* 
Subclasses.cs
***************************************************************** 
namespace TreehouseDefense
{
 class MapLocation : Point // Point is subclass of Maplocation
 {
   public MapLocation(int x, int y) : base(x, y)
   {
     
   }
 }
} 
*****************************************************************
*/

using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
          Map map = new Map(8, 5);
          
          Point x = new MapLocation(4, 2);
          
          Point p = x;
          
          map.OnMap(new MapLocation(0, 0));

          Console.WriteLine(x.DistanceTo(5, 5));
          
          Console.WriteLine(x is MapLocation); // True: x is a MapLocation
          Console.WriteLine(x is Point); // True: x is a Point
          
          Point point = new Point(0, 0);
          Console.WriteLine(point is MapLocation); // False: point is not a MapLocation
        }
    }
}