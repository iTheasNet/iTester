using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.TestsSample
{
    

    [TestFixture]
    public class TestClass
    {
        private string _TestMessage;

        [SetUp]
        public void SetupForTest()
        {
            _TestMessage = "Your first passing test.";
            _TestMessage = "Your first passing test.";
           
        }
        [Test]
        public void TestMethodAruna()
        {
            // TODO: Add your test code here
            Assert.Pass(_TestMessage);
            
        }
        [Test]
        public void TestMethodAruna2()
        {
            // TODO: Add your test code here
            Assert.Pass(_TestMessage);
          
        }
        [TearDown]
        public void TearDownAfterTest()
        {
            _TestMessage = string.Empty;
            
        }
    }
}
