using System;

namespace Interface
{
    interface inter1
    {
        void display();
    }

    class testClass : inter1
    {
        public void display()
        {
            Console.WriteLine("This is the method of testclass.");
        }
    }
     public class Program
     {
            static void Main(string[] args)
            {
                testClass tc = new testClass();
                tc.display();
            }
     }
}

