using advent.Extensions;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text.RegularExpressions;

namespace advent.Days._2015
{
    public class Day12 : Day
    {
        private readonly Regex _numberRegex = new Regex(@"[-]?\d+", RegexOptions.Compiled);

        public override string Part1(string input)
        {
            return _numberRegex.Matches(input).Sum(x => x.Value.ToInt()).ToString();
        }

        public override string Part2(string input)
        {
            var json = JToken.Parse($"[{input}]");

            return CalculateSum(json).ToString();
        }

        private int CalculateSum(JToken json)
        {
            var value = 0;

            foreach (var element in json)
            {
                if (element.Type == JTokenType.None)
                {
                    value += 0;
                }
                else if (element.Type == JTokenType.Object)
                {
                    if (element.Any(x => x.Type == JTokenType.Property && ((JProperty)x).Value.ToString() == "red")) continue;
                    value += CalculateSum(element);
                }
                else if (element.Type == JTokenType.Array)
                {
                    value += CalculateSum(element);
                }
                else if (element.Type == JTokenType.Property)
                {
                    value += CalculateSum(element);
                }
                else if (element.Type == JTokenType.Integer)
                {
                    value += (int)element;
                }
            }

            return value;
        }
    }
}
