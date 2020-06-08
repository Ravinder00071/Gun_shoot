using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExceptionCase()
        {
            try
            {


            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Working fine");
                return;
            }
            Assert.Fail("No Exception was thrown");
        }
    }
}
