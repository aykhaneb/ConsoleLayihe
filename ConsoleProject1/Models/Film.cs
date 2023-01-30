using System;

namespace ConsoleApp11
{
    public class Film : Entity
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}