using advent.Models._2021;

namespace advent.Days._2021
{
    public class Day09 : Day
    {
        public override string Part1(string input)
        {
            var heightMap = new HeightMap(input);

            return heightMap.GetRiskLevel()
                .ToString();
        }

        public override string Part2(string input)
        {
            var heightMap = new HeightMap(input);

            return heightMap.GetBasinSizes()
                .ToString();
        }
    }
}
