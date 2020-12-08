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

    public class Bootcode
    {
        public int Accumulator { get; private set; }

        private readonly string[] _instructions;

        public Bootcode(string[] instructions)
        {
            _instructions = instructions;
        }

        public bool Execute()
        {
            var seen = new HashSet<int>();

            var index = 0;

            seen.Add(index);

            index = ProcessLine(index);

            while (seen.Add(index))
            {
                if (_instructions.Length <= index) // we reached the end
                {
                    return true;
                }

                index = ProcessLine(index);
            }

            return false;
        }

        private int ProcessLine(int index)
        {
            var line = _instructions[index];

            var parts = line.Split();

            var instruction = parts[0];
            var operation = parts[1][0];
            var value = int.Parse(parts[1][1..]);

            int next = index + 1;

            switch (instruction)
            {
                case "jmp":
                    next = index + JumpInstruction(operation, value);
                    break;
                case "acc":
                    IncreaseAccumulator(operation, value);
                    break;
                case "nop":
                    break;
            }

            return next;
        }

        private void IncreaseAccumulator(char operation, int value)
        {
            if (operation == '+')
            {
                Accumulator += value;
            }
            else if (operation == '-')
            {
                Accumulator -= value;
            }
        }

        private int JumpInstruction(char operation, int value)
        {
            if (operation == '+')
            {
                return value;
            }
            else if (operation == '-')
            {
                return -value;
            }

            return 0;
        }
    }
}
