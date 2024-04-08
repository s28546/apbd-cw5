using System.Drawing;

namespace WebApplication
{
    public class Animal
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public float Mass { get; private set; }
        public Color Color { get; private set; }

        public Animal(int id, string name, string category, float mass, Color color)
        {
            Id = id;
            Name = name;
            Category = category;
            Mass = mass;
            Color = color;
        }
    }
}