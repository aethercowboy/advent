using System.Collections.Generic;

namespace advent.Models._2020
{
    public class BootcodeFixer
    {
        private readonly string[] _instructions;

        public BootcodeFixer(string[] intructions)
        {
            _instructions = intructions;
        }

        public int Execute()
        {
            var bootcode = new Bootcode(_instructions);

            if (bootcode.Execute())
            {
                return bootcode.Accumulator;
            }

            for (var i = 0; i < _instructions.Length; ++i)
            {
                var line = _instructions[i];

                if (line.StartsWith("jmp") || line.StartsWith("nop"))
                {
                    var newInstructions = new string[_instructions.Length];
                    _instructions.CopyTo(newInstructions, 0);

                    if (line.StartsWith("jmp"))
                    {
                        newInstructions[i] = newInstructions[i].Replace("jmp", "nop");
                    }
                    else if (line.StartsWith("nop"))
                    {
                        newInstructions[i] = newInstructions[i].Replace("nop", "jmp");
                    }

                    var newBootcode = new Bootcode(newInstructions);

                    if (newBootcode.Execute())
                    {
                        return newBootcode.Accumulator;
                    }
                }
            }

            return 0;
        }
    }
}
