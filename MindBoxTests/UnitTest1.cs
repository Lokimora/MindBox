using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxDomain.Helpers;

namespace MindBoxTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tickets = TicketHelper.GenerateTickets();
            var sorted = TicketSortManager.Sort(tickets);

            bool result = TicketHelper.IsOrdered(sorted.ToArray());

            Assert.AreEqual(result, true);
        }
    }
}
