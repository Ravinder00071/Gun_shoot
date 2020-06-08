using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gun_shoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun_shoot.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            try
            {

            }
            catch (ApplicationException e)
            {
                StringAssert.Contains(e.Message, "No application Exception occurs");
                return;
            }
            Assert.Fail("Bummer");
        }
    }
}