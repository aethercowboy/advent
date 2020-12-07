using advent.Extensions;
using advent.Models._2020;
using Xunit;

namespace advent.tests.Days._2020.Models
{
    public class PassportTests
    {
        [Theory]
        [InlineData("2002", true)]
        [InlineData("2003", false)]
        public void BirthYearTest(string birthYear, bool expected)
        {
            var result = Passport.IsBirthYearValid(birthYear);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("60in", true)]
        [InlineData("190cm", true)]
        [InlineData("190in", false)]
        [InlineData("190", false)]
        public void HeightTest(string height, bool expected)
        {
            var result = Passport.IsHeightValid(height);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("#123abc", true)]
        [InlineData("#123abz", false)]
        [InlineData("123abc", false)]
        public void HairColorTest(string hairColor, bool expected)
        {
            var result = Passport.IsHairColorValid(hairColor);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("brn", true)]
        [InlineData("wat", false)]
        public void EyeColorTest(string eyeColor, bool expected)
        {
            var result = Passport.IsEyeColorValid(eyeColor);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("000000001", true)]
        [InlineData("0123456789", false)]
        public void PassportIdTest(string passportId, bool expected)
        {
            var result = Passport.IsPassportIdValid(passportId);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(@"eyr:1972 cid:100
hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926", false)]
        [InlineData(@"iyr:2019
hcl:#602927 eyr:1967 hgt:170cm
ecl:grn pid:012533040 byr:1946", false)]
        [InlineData(@"hcl:dab227 iyr:2012
ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277", false)]
        [InlineData(@"hgt:59cm ecl:zzz
eyr:2038 hcl:74454a iyr:2023
pid:3556412378 byr:2007", false)]
        [InlineData(@"pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980
hcl:#623a2f", true)]
        [InlineData(@"eyr:2029 ecl:blu cid:129 byr:1989
iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm", true)]
        [InlineData(@"hcl:#888785
hgt:164cm byr:2001 iyr:2015 cid:88
pid:545766238 ecl:hzl
eyr:2022", true)]
        [InlineData("iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719", true)]
        public void AreFieldsValid(string data, bool expected)
        {
            var buffer = data.Lines();
            var passport = new Passport(buffer);

            Assert.Equal(expected, passport.AreFieldsValid());
        }
    }
}
