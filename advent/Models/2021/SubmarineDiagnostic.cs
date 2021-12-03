using advent.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace advent.Models._2021
{
    internal class SubmarineDiagnostic
    {
        public int Gamma { get; }
        public int Epislon { get; }

        private readonly SubmarineDiagnosticsData _data;

        public SubmarineDiagnostic(string input)
        {
            _data = new SubmarineDiagnosticsData(input);

            var gammas = new int[_data.Length];
            var epislons = new int[_data.Length];

            for (var i = 0; i < _data.Length; i++)
            {
                gammas[i] = MostCommonValue(i);
                epislons[i] = gammas[i] ^ 1;
            }

            var gammaString = new string(gammas.Select(x => x.ToCharDigit()).ToArray());
            var epislonString = new string(epislons.Select(x => x.ToCharDigit()).ToArray());

            Gamma = Convert.ToInt32(gammaString, 2);
            Epislon = Convert.ToInt32(epislonString, 2);
        }

        public int GetPowerConsumption()
        {
            return Gamma * Epislon;
        }

        public int GetLifeSupportRating()
        {
            return GetOxygenGeneratorRating() * GetCO2ScrubberRating();
        }

        public int GetOxygenGeneratorRating()
        {
            var data = _data.Data;

            for (var i = 0; i < _data.Length; i++)
            {
                if (data.Count == 1) break;

                var mcv = MostCommonValue(i, data).ToCharDigit();

                data = data.Where(x => x[i] == mcv).ToList();
            }

            return Convert.ToInt32(data[0], 2);
        }

        public int GetCO2ScrubberRating()
        {
            var data = _data.Data;

            for (var i = 0; i < _data.Length; i++)
            {
                if (data.Count == 1) break;

                var mcv = (MostCommonValue(i, data) ^ 1).ToCharDigit();

                data = data.Where(x => x[i] == mcv).ToList();
            }

            return Convert.ToInt32(data[0], 2);
        }

        private int MostCommonValue(int i)
        {
            return MostCommonValue(i, _data.Data);
        }

        private static int MostCommonValue(int i, IList<string> data)
        {
            var value = 0;

            foreach (var line in data)
            {
                value += int.Parse(line[i].ToString());
            }

            var count = (double)data.Count / 2;

            return value >= count
                    ? 1
                    : 0;
        }
    }

    internal class SubmarineDiagnosticsData
    {
        public IList<string> Data { get; }
        public int Length { get; }

        public SubmarineDiagnosticsData(string input)
        {
            Data = input.Lines()
                .ToList();

            Length = Data[0].Length;
        }

        public int Count => Data.Count;
    }
}
