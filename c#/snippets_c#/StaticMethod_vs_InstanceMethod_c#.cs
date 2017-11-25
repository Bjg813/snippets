using System;

namespace lawyer_game
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Static Method");
          Console.WriteLine(Customer.StaticMethod());

        
          Console.WriteLine("Instance Method");

          Customer cust = new Customer();

          Console.WriteLine(cust.InstanceMethod());
        }
    }
    class Customer
    {
        public string InstanceMethod()
        {
            if (whatToSay == string.Empty)
            {
            return "Hello from the Instance Method of the Customer Class";
            }
            else
            {
            return whatToSay;
            }
        }

        public static string StaticMethod()
        {
            return "Hello from the Static Method of the Customer Class";
        }
        // Create a Property using "propfull" code snippet
        private string whatToSay = string.Empty;
        public string WhatToSay
        {
            get { return whatToSay;}
            set { whatToSay = value;}
        }
        
    }
}
