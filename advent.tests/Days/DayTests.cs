using advent.Days;
using advent.IO;
using System;

namespace advent.tests.Days
{
    public abstract class DayTests<TDay>
        where TDay : Day, new()
    {
        protected readonly TDay Client;
        protected string Output = string.Empty;

        protected DayTests()
        {
            Client = new TDay();
            Client.Console.Wrote += OnWrote;
        }

        protected void OnWrote(object sender, EventArgs e)
        {
            if (e is ConsoleEventArgs f)
            {
                Output = f.Message;
            }
        }
    }
}
