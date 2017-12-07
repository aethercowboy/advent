using advent.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace advent.tests.Days
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
