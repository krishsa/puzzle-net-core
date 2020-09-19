using System;

namespace puzzle_net_core
{
    public class Parent
    {
        public string Name { get; private set; }

        public Parent(string name)
        {
            Name = name;
        }
        public Parent()
        {
        }
    }

    public class Child : Parent
    {

        private Child(string name) : base(name)
        {
            Console.WriteLine(this.Name);
        }
        //Factroy method
        public static Child ManipulateString(string str)
        {
            return new Child(str.ToUpper());
        }

    }

}