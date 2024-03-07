using System;

namespace MethodOverriding
{
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is the method of Parent class.");
        }
    }
    class child : parent 
    {
        public override void print()
        {
            Console.WriteLine("This is the method of child class.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            parent p=new child();
            p.print();
        }
    }
}
