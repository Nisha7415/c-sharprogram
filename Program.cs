using System;

namespace MethodOverloading
{ 
    
    public class Program
    {
        public  void Add()
        {
            int a = 10, b = 20;
            Console.WriteLine("Addition is :- " + (a + b));
        }
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition is :- " + (a + b));
        }
        public void Add(double a, double b)
        {
            Console.WriteLine("Addition is :- " + (a + b));
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Add();
            p.Add(12,24);
            p.Add(1.22, 2.4);
        }
    }
}
