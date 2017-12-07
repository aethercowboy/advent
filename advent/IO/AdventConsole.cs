using System;

namespace advent.IO
{
    public class AdventConsole : IConsole
    {
        public string WriteOutput(string input)
        {
            Console.WriteLine(input);

            Wrote?.Invoke(this, new ConsoleEventArgs {Message = input});

            return input;
        }

        public void WriteLine(string input = null)
        {
            if (input == null)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(input);
            }
        }

        public void Write(string input)
        {
            Console.Write(input);
        }

        public event EventHandler Wrote;
    }
}
