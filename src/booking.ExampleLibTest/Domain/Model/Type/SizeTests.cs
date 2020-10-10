using Microsoft.VisualStudio.TestTools.UnitTesting;
using booking.ExampleLib.Domain.Model.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace booking.ExampleLib.Domain.Model.Type.Tests
{
    [TestClass()]
    public class SizeTests
    {
        [TestMethod()]
        public void MultiplyTest()
        {
            var size = new Size(100);
            size.Value.Is(100);

            size.Multiply(new Percent(10)).Value.Is(10);
        }
    }
}