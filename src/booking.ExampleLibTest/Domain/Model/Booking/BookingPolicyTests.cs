using Microsoft.VisualStudio.TestTools.UnitTesting;
using booking.ExampleLib.Domain.Model.booking;
using booking.ExampleLib.Domain.Model.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.ExampleLib.Domain.Model.booking.Tests
{
    [TestClass()]
    public class BookingPolicyTests
    {
        [TestMethod()]
        public void SizeMaxTest()
        {
            var bookingPolicy = new BookingPolicy(new Percent(10));
            var size = bookingPolicy.SizeMax(new Size(100));

            size.Value.Is(110);
        }
    }
}