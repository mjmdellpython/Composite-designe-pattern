using System.Collections.Generic;

namespace compositPattern.composit
{
    public class CompositComponent : Component
    {
        List<Component> children = new List<Component>();
        private readonly string _name;
        public CompositComponent(string name) : base(name)
        {
            _name = name;

        }
        public override void add(Component c)
        {
            children.Add(c);
        }

        public override void display(int depth)
        {
            System.Console.WriteLine(depth + " " + _name);

            foreach (Component item in children)
            {
                item.display(depth);
            }
        }

        public override void remove(Component c)
        {
            children.Remove(c);
        }
    }
}