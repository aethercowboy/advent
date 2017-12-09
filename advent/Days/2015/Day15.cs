using System;
using System.Collections.Generic;
using System.Linq;
using advent.Extensions;

namespace advent.Days._2015
{
    public class Day15 : Day
    {
        private class Ingredient
        {
            public int Capacity { get; set; }
            public int Durability { get; set; }
            public int Flavor { get; set; }
            public int Texture { get; set; }
            public int Calories { get; set; }
        }

        private class Cookie
        {
            public IDictionary<Ingredient, int> Ingredients { get; set; }
        }

        public int Teaspoons = 100;

        public override int Part1(string input)
        {
            var list = new List<Ingredient>();

            foreach (var line in input.Lines())
            {
                
            }

            throw new NotImplementedException();
        }

        public override int Part2(string input)
        {
            throw new NotImplementedException();
        }
    }
}
