using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorldEnterprise.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var receiver = new Mock<IRecevier>();
            var greeting = new Greeting(receiver.Object);
            greeting.SayHello("World");

            receiver.Verify(m => m.ReceiveMessage("Hello World!"));
        }
    }
}
