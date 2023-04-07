using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using Xunit;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameMoreThanTen_POSITIVE()
        {
            string name = "John Dododo";

            Assert.IsTrue(name.Length > 10);
        }
        [TestMethod]
        public void NameMoreThanTen_NEGATIVE()
        {
            string name = "John";

            Assert.IsTrue(name.Length > 10);
        }
        [TestMethod]
        public void NameIsNull()
        {
            string name = "John Do";
            Assert.IsNull(name);
        }
        [TestMethod]
        public void NameIsNotNull()
        {
            string name = null
            Assert.IsNull(name);
        }
        [TestMethod]
        public void AtributLevelInicialzedToOne()
        {
            int level = 1;
            Assert.AreEqual(level, 1);
        }
        [TestMethod]
        public void AtributLevelNotInicialzedToOne()
        {
            int level = 1;
            Assert.AreNotEqual(level, 1);
        }
        [TestMethod]
        public void AtributPoziceInicialzedToZero()
        {
            int pozicex = 0;
            int pozicey = 0;
            Assert.IsTrue(pozicex == 0 || pozicey == 0);
        }
        [TestMethod]
        public void AtributPoziceNotInicialzedToZero()
        {
            int pozicex = 0;
            int pozicey = 0;
            Assert.IsFalse(pozicex == 0 || pozicey == 0);
        }
        [TestMethod]
        public void CorrectFieldBelong()
        {
            string field = "Wizard/Berserker/Engineer/Outsider";
            string fieldinuse = "Wizard";
            Assert.IsTrue(field.Contains(fieldinuse));
        }
        [TestMethod]
        public void FaceAtributInicializedStartLvl_P()
        {
            int face = 0;
            Assert.AreEqual(face, 0);
        }
        [TestMethod]
        public void FaceAtributInicializedStartLvl_N()
        {
            int face = 1;
            Assert.AreEqual(face, 0);
        }
        [TestMethod]
        public void HairAtributInicializedStartLvl_P()
        {
            int face = 0;
            Assert.AreEqual(face, 0);
        }
        [TestMethod]
        public void HairAtributInicializedStartLvl_N()
        {
            int face = 1;
            Assert.AreEqual(face, 0);
        }
        [TestMethod]
        public void HairColorAtributInicializedStartLvl_P()
        {
            int face = 0;
            Assert.AreEqual(face, 0);
        }
        [TestMethod]
        public void HairColorAtributInicializedStartLvl_N()
        {
            int face = 1;
            Assert.AreEqual(face, 0);
        }
        [TestMethod]
        public void AddXPWorking()
        {
            int XP = 1;
            int XP1 = XP + 1;
            Assert.AreNotEqual(XP, XP1);
        }
        [TestMethod]
        public void AddXPNotWorking()
        {
            int XP = 1;
            int XP1 = XP;
            Assert.AreNotEqual(XP, XP1);
        }
        [TestMethod]
        public void LevelUpWorking()
        {
            int level = 1;
            int XP = 100;
            Assert.IsTrue(XP >= level * 100);
        }
        [TestMethod]
        public void LevelUpNotWorking()
        {
            int level = 1;
            int XP = 1;
            Assert.IsTrue(XP >= level * 100);
        }

    }
}