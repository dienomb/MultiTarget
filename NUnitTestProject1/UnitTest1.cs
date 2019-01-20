using NUnit.Framework;
using Moq;
using Library;

namespace Tests
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Test1()
        {
            var factory = new Mock<IHello>();
            factory.Setup(x => x.SayHello(It.IsAny<string>()))
                .Returns("hola");
            
            Assert.Pass();
        }
    }
}