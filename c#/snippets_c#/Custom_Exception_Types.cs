// Custom Exception Types
namespace TreehouseDefense
{
 class TreehouseDefenseException : System.Exception  //Subclass of System.Exception
 {
   
   public TreehouseDefenseException() //Exception that doesnt have parameters
   {
   }
   public TreehouseDefenseException(string message) : base(message) //Exception that does have parameters/message
   {
     
   }
 }
  
  class OutOfBoundsException : TreehouseDefenseException //Subclass of TreehouseDefenseException
  {
    
    public OutOfBoundsException() //Exception that doesnt have parameters
    {
    }
    public OutOfBoundsException(string message) : base(message) //Exception that does have paramters/message
    {
      
    }
  }
  
  
}
  