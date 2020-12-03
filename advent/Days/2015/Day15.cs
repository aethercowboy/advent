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
            public string Name { get; set; }
            public int Capacity { get; set; }
            public int Durability { get; set; }
            public int Flavor { get; set; }
            public int Texture { get; set; }
            public int Calories { get; set; }
        }

        private class Cookie
        {
            public IDictionary<Ingredient, int> Ingredients { get; } = new Dictionary<Ingredient, int>();

            public int Calories => Math.Max(Ingredients.Sum(x => x.Value * x.Key.Calories), 0);
            public int Weight => Ingredients.Sum(y => y.Value);

            public int Score()
            {
                var capacity = Ingredients.Sum(x => x.Value * x.Key.Capacity);
                var durability = Ingredients.Sum(x => x.Value * x.Key.Durability);
                var flavor = Ingredients.Sum(x => x.Value * x.Key.Flavor);
                var texture = Ingredients.Sum(x => x.Value * x.Key.Texture);

                return Math.Max(capacity, 0)
                       * Math.Max(durability, 0)
                       * Math.Max(flavor, 0)
                       * Math.Max(texture, 0);
            }
        }

        public int Teaspoons = 100;

        private static IEnumerable<Cookie> GenerateCookies(ICollection<Ingredient> ingredients, int teaspoons)
        {
            foreach (var item in ingredients)
            {
                var start = 0;

                if (ingredients.Count == 1)
                {
                    start = teaspoons;
                }

                foreach (var i in Enumerable.Range(start, teaspoons + 1 - start))
                {
                    var leftovers = ingredients.Where(x => x.Name != item.Name).ToList();

                    var cookies = GenerateCookies(leftovers, teaspoons - i);

                    var none = true;

                    foreach (var cookie in cookies)
                    {
                        none = false;
                        cookie.Ingredients.Add(item, i);

                        if (cookie.Weight == teaspoons)
                        {
                            yield return cookie;
                        }
                    }

                    if (!none) continue;

                    {
                        var cookie = new Cookie();

                        cookie.Ingredients.Add(item, i);

                        if (cookie.Weight == teaspoons)
                        {
                            yield return cookie;
                        }
                    }
                }
            }
        }

        private IEnumerable<Cookie> Part0(string input)
        {
            var list = input.Lines()
                .Select(line => line.Words().ToList())
                .Select(words => new
                {
                    key = words[0].Trim(':'),
                    cap = words[2].Trim(',').ToInt(),
                    dur = words[4].Trim(',').ToInt(),
                    fla = words[6].Trim(',').ToInt(),
                    tex = words[8].Trim(',').ToInt(),
                    cal = words[10].ToInt()
                })
                .Select(t => new Ingredient
                {
                    Name = t.key,
                    Capacity = t.cap,
                    Durability = t.dur,
                    Flavor = t.fla,
                    Texture = t.tex,
                    Calories = t.cal
                })
                .ToList();

            var cookies = GenerateCookies(list, Teaspoons);

            return cookies;
        }

        public override int Part1(string input)
        {
            var cookies = Part0(input);

            var maxCookie = cookies.Max(x => x.Score());

            return maxCookie;
        }

        public override long Part2(string input)
        {
            var cookies = Part0(input);

            var maxCookie = cookies.Where(x => x.Calories == 500).Max(x => x.Score());

            return maxCookie;
        }
    }
}
