using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetStandardClassLibrary;

namespace NetCoreMSTest
{
    [TestClass]
    public class StaticInvokerTests
    {
        [TestMethod]
       public void GetAsync_WithOverrideForStaticMethodInPlace_ReturnsSameTextFromOverrideMethod()
        {
            // Arrange
            StaticInvokerOverrider staticInvokerOverriderInstance = new StaticInvokerOverrider();

            // Act
            string actualResult = staticInvokerOverriderInstance.Get();

            // Assert
            Assert.AreEqual("return from Overrider class", actualResult);
        }
    }

    class StaticInvokerOverrider : StaticInvoker
    {
        public new string Get()
        {
            return base.Get();
        }

        protected override string CallStaticMethod()
        {
            return "return from Overrider class";
        }
    }
}
