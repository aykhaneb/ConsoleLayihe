using ConsoleApp11;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Models
{
    public class Bilet : Entity
    {
        //private static int _id = 1;
        public Seans Seans { get; set; }

        public override string ToString()
        {
            return $"{Seans}";
        }
    }
}