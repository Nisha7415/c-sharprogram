using System;

namespace SingleInheritance
{
    class BaseClass
    {
        public string brand = "Ford";  
        public void show1()             
        {
            Console.WriteLine("This is a method of Base class..");
        }
    }

    class DerivedClass : BaseClass 
    {
        public void show2()
        {
            Console.WriteLine("This is a method of Derived class..");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            
            DerivedClass dc= new DerivedClass();
            dc.show2();
            dc.show1 ();
        }
    }
}
