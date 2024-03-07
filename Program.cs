using System;

namespace HierachicalInheritance
{
    class BaseClass
    {
        public string brand = "Ford";
        public void show1()
        {
            Console.WriteLine("This is a method of Base class..");
        }
    }

    class DerivedClass1 : BaseClass
    {
        public void show2()
        {
            Console.WriteLine("This is a method of First Derived class..");
        }
    }
    class DerivedClass2 : BaseClass
    {
        public void show3()
        {
            Console.WriteLine("This is a method of Second Derived class..");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            DerivedClass1 dc = new DerivedClass1();
            dc.show2();
            dc.show1();
        }
    }
}
