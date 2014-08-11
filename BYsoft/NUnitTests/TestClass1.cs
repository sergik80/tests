using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Core;
using NUnitTests;

namespace NUnitTests
{
    [TestFixture]
    public class TestClass1
    {
        [TestCase(2, 2, 4)]
        [TestCase(2,4,6)]
        public void TestSmth(int a, int b, int d) 
        {
            Assert.IsTrue(a + b == d);
        }


    }
}
