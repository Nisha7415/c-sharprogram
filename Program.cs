using System;

namespace Encapsulation
{
     public class person
    {
        private String Name;
        private int age;

        public void SetName(String Name,int age)

        {
            this.Name = Name;
            this.age = age;
        }
        public void GetName()
        {
            Console.WriteLine("Name is :- " + this.Name);
            Console.WriteLine("Age is :-  " + this.age);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           person p= new person();
            p.SetName("Nisha",23);
            p.GetName();
        }
    }
}
