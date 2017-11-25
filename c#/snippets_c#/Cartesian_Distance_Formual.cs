namespace TreehouseDefense
{
 class Point
 {
  public readonly int X;
  public readonly int Y;
   
  public Point(int x, int y) 
  {
    X = x;
    Y = y;
  }
   
   public int DistanceTo(int x, int y)
   {     
      // Cartesian Distance Formula
      // The square root of the horizontal distance between the points squared plus the vertical distance between the points squared
      int xDiff = X - x;
      int yDIff = Y - y; 
     
     int xDiifSquared = xDiff * xDiff;
     int yDiffSquared = yDiff * yDiff;
      
     return Math.Sqrt(xDiffSquared + yDiffSquared);

     // Math.Pow method: returns a specified number to the specified power
     return Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
   }
 }
} 