using System;

namespace compositPattern.leaf
{
    public class LeafComponent : Component
    {
        private readonly string _name;
        public LeafComponent(string name) : base(name)
        {
            _name = name;

        }
        public override void add(Component c)
        {
            System.Console.WriteLine("Add operation");
        }

        public override void display(int depth)
        {
            System.Console.WriteLine(depth + " - " + _name);
        }

        public override void remove(Component c)
        {
            System.Console.WriteLine("Remove operation");
        }
    }
}