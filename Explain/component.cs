namespace compositPattern
{
    public abstract class Component
    {
        public string Name { get; }
        public Component(string name)
        {
            Name = name;
        }

        public abstract void add(Component c);
        public abstract void remove(Component c);
        public abstract void display(int depth);
    }


}