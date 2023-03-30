using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;



namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = "John Do";
            HerniPostava character = new HerniPostava(name);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(name, character.Name);
            
        }
    }
}