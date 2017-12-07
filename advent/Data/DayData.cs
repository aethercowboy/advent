using System.IO;

namespace advent.Data
{
    public static class DayData
    {
        public static string LoadFile(int year, string day)
        {
            var path = Path.Combine("Data", year.ToString(), $"{day}.txt");
            return File.Exists(path)
                    ? File.ReadAllText(path)
                    : string.Empty
                ;
        }
    }
}