using System;
using advent.Days;
using advent.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days
{
    public abstract class DayTests<TDay>
        where TDay : Day, new()
    {
        protected TDay Client;
        protected string Output = string.Empty;

        [TestInitialize]
        public void Startup()
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
