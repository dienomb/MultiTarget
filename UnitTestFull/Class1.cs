using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace UnitTestFull
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var factory = new Mock<IHello>();
            factory.Setup(x => x.SayHello(It.IsAny<int>()))
                .Returns(2);

            Assert.Pass();
        }
    }
}
