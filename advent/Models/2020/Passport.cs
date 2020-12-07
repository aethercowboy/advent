using advent.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace advent.Models._2020
{
    public class Passport
    {
        public string BirthYear { get; }
        public string IssueYear { get; }
        public string ExpirationYear { get; }
        public string Height { get; }
        public string HairColor { get; }
        public string EyeColor { get; }
        public string PassportId { get; }
        public string CountryId { get; }

        public Passport(IEnumerable<string> buffer)
        {
            foreach (var line in buffer)
            {
                foreach (var pair in line.Split())
                {
                    var kv = pair.Split(':');

                    var key = kv[0];
                    var value = kv[1];

                    switch (key)
                    {
                        case "byr":
                            BirthYear = value;
                            break;
                        case "iyr":
                            IssueYear = value;
                            break;
                        case "eyr":
                            ExpirationYear = value;
                            break;
                        case "hgt":
                            Height = value;
                            break;
                        case "hcl":
                            HairColor = value;
                            break;
                        case "ecl":
                            EyeColor = value;
                            break;
                        case "pid":
                            PassportId = value;
                            break;
                        case "cid":
                            CountryId = value;
                            break;
                    }
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("byr:").Append(BirthYear).Append(' ')
                .Append("iyr:").Append(IssueYear).Append(' ')
                .Append("eyr:").Append(ExpirationYear).Append(' ')
                .Append("hgt:").Append(Height).Append(' ')
                .Append("hcl:").Append(HairColor).Append(' ')
                .Append("ecl:").Append(EyeColor).Append(' ')
                .Append("pid:").Append(PassportId).Append(' ')
                .Append("cid:").Append(CountryId).Append(' ')
                ;

            return sb.ToString();
        }

        public bool HasRequiredFields()
        {
            return !string.IsNullOrEmpty(BirthYear)
                && !string.IsNullOrEmpty(IssueYear)
                && !string.IsNullOrEmpty(ExpirationYear)
                && !string.IsNullOrEmpty(Height)
                && !string.IsNullOrEmpty(HairColor)
                && !string.IsNullOrEmpty(EyeColor)
                && !string.IsNullOrEmpty(PassportId)
                ;
        }

        public bool AreFieldsValid()
        {
            return IsBirthYearValid(BirthYear)
                && IsIssueYearValid(IssueYear)
                && IsExpirationYearValid(ExpirationYear)
                && IsHeightValid(Height)
                && IsHairColorValid(HairColor)
                && IsEyeColorValid(EyeColor)
                && IsPassportIdValid(PassportId)
                ;
        }

        internal static bool IsBirthYearValid(string birthYear)
        {
            return IsRangeValid(birthYear, 1920, 2002);
        }

        internal static bool IsIssueYearValid(string issueYear)
        {
            return IsRangeValid(issueYear, 2010, 2020);
        }

        internal static bool IsExpirationYearValid(string expirationYear)
        {
            return IsRangeValid(expirationYear, 2020, 2030);
        }

        private static bool IsRangeValid(string range, int min, int max)
        {
            if (int.TryParse(range, out var r))
            {
                return r >= min
                    && r <= max;
            }

            return false;
        }

        internal static bool IsHeightValid(string height)
        {
            var parts = height.SplitAt(height.Length - 2)
                .ToList();

            if (parts.Count == 2)
            {
                return (parts[1]) switch
                {
                    "in" => IsRangeValid(parts[0], 59, 76),
                    "cm" => IsRangeValid(parts[0], 150, 193),
                    _ => false,
                };
            }

            return false;
        }

        private static readonly Regex hairColorPattern = new Regex("^#[0-9a-f]{6}$");

        internal static bool IsHairColorValid(string hairColor)
        {
            return hairColorPattern.IsMatch(hairColor);
        }

        private static readonly List<string> validEyeColors = new List<string> { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

        internal static bool IsEyeColorValid(string eyeColor)
        {
            return validEyeColors.Contains(eyeColor);
        }

        private static readonly Regex passportIdPattern = new Regex(@"^\d{9}$");

        internal static bool IsPassportIdValid(string passportId)
        {
            return passportIdPattern.IsMatch(passportId);
        }
    }
}
