using advent.IO;
using System;
using Xunit.Abstractions;

namespace advent.tests.Consoles
{
    internal class TestConsole : IConsole
    {
        private readonly ITestOutputHelper _output;

        public TestConsole(ITestOutputHelper output)
        {
            _output = output;
        }

        event EventHandler IConsole.Wrote
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void IConsole.Write(string input)
        {
            throw new NotImplementedException();
        }

        void IConsole.WriteLine(string message)
        {
            _output.WriteLine(message);
        }

        string IConsole.WriteOutput(string input)
        {
            throw new NotImplementedException();
        }
    }
}
