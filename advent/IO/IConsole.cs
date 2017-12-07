using System;
using System.Collections.Generic;
using System.Text;

namespace advent.IO
{
    public interface IConsole
    {
        string WriteOutput(string input);
        void WriteLine(string input);
        void Write(string input);

        event EventHandler Wrote;
    }

    public class ConsoleEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
