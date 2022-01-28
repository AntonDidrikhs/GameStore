using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace GameStoreUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new GamesController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);

        }
    }
}
