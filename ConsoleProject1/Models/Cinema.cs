using System;

namespace ConsoleApp11
{
    public class Cinema : Entity
    {
        public string Name { get; set; }

        public Zal[] Zals { get; set; } = new Zal[17];

        public override string ToString()
        {
            string zallar = "";

            foreach (var item in Zals)
            {
                if (item == null)
                    continue;

                zallar += item + "\n";
            }

            return $" {Id} {Name}\n";

        }
    }
}
