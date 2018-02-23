using System;
using MethodsDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbcDevForce;

namespace GeneralTests
{
    [TestClass]
    public class UnitTestOne
    {
        [TestMethod]
        public void TestMethodOne()
        {
            //Arrange
            DummyClass target=new DummyClass();
            //Act
            int result = target.AdditionMethod(3, 5);
            //Assert
            Assert.AreEqual(8,result);
        }

        [TestMethod]
        public void TestMethodTwo()
        {
            TestClass testObject=new TestClass();
            Assert.AreEqual(true,testObject.Draw1());
        }
    }
}
