/*
******************************************************************************************************************
 The Polygon class represents a 2 dimensional shape. It has a public field named NumSides. Create a new type of polygon called Square. It should have a public readonly field named SideLength that’s initialized using the constructor. Use base to initialize NumSides to 4. 
 *****************************************************************************************************************
 */

/*
******************************************************************************************************************
 Just make another class in the same file (remember you can have multiple classes in one file!) called Square and have it extend Polygon. From there, you can initialize the SideLength variable: 
******************************************************************************************************************
*/


namespace Treehouse.CodeChallenges
{
    class Polygon
    {
        public readonly int NumSides;

        public Polygon(int numSides)
        {
            NumSides = numSides;
        }
    }
    
    class Square : Polygon
    {
        public readonly int SideLength;
        public Square(int sideLength) : base(4)
        {
            SideLength = sideLength;
        }
    }
}