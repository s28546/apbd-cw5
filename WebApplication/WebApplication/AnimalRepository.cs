using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace WebApplication
{
    public class AnimalRepository
    {
        public static readonly List<Animal> Database = new List<Animal>()
        {
            new Animal(1, "Ala1", "Kot", 10, Color.Blue),
            new Animal(2, "Ala2", "Kot", 10, Color.Blue),
            new Animal(3, "Ala3", "Kot", 10, Color.Blue),
            new Animal(4, "Ala4", "Kot", 10, Color.Blue),
            new Animal(5, "Ala5", "Kot", 10, Color.Blue),
            new Animal(6, "Ala6", "Kot", 10, Color.Blue)
        };
    }
}    

