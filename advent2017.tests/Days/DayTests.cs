using System;
using System.Collections.Generic;
using System.Text;
using advent2017.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent2017.tests.Days
{
    public abstract class DayTests<TDay>
        where TDay : IDay, new()
    {
        protected TDay Client;

        [TestInitialize]
        public void Startup()
        {
            Client = new TDay();
        }
    }
}
