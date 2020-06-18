using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void physicalProductTest()
        {
            PhysicalProduct physicalProduct = new PhysicalProduct();
            string physicalProductString = physicalProduct.GetBusinessRuleLogic();
            Assert.AreEqual(physicalProductString, "packing slip for shipping");
            Assert.AreNotEqual(physicalProductString, "packing slip for shipping1");
        }

        [TestMethod]
        public void BookTest()
        {
            Book Book = new Book();
            string bookString = Book.GetBusinessRuleLogic();
            Assert.AreEqual(bookString, "create a duplicate packing slip for royality department");
            Assert.AreNotEqual(bookString, "create a duplicate packing slip for royality department1");
        }

        [TestMethod]
        public void MembershipTest()
        {
            Membership membership = new Membership();
            string membershipString = membership.GetBusinessRuleLogic();
            Assert.AreEqual(membershipString, "Activate the Membership");
            Assert.AreNotEqual(membershipString, "create a duplicate packing slip for royality department");
        }

        [TestMethod]
        public void UpgradeTest()
        {
            Upgrade upgrade = new Upgrade();
            string upgradeString = upgrade.GetBusinessRuleLogic();
            Assert.AreEqual(upgradeString, "Applying for Upgrade");
            Assert.AreNotEqual(upgradeString, "create a duplicate packing slip for royality department");
        }

        [TestMethod]
        public void MembershipOrUpgradeTest()
        {
            MembershipOrUpgrade membershipOrUpgrade = new MembershipOrUpgrade();
            string membershipOrUpgradeString = membershipOrUpgrade.GetBusinessRuleLogic();
            Assert.AreEqual(membershipOrUpgradeString, "email to the owner and inform them of activation / Upgrade");
            Assert.AreNotEqual(membershipOrUpgradeString, "create a duplicate packing slip for royality department");
        }

        [TestMethod]
        public void LearningToSKITest()
        {
            LearningToSKI learningToSKI = new LearningToSKI();
            string learningToSKIString = learningToSKI.GetBusinessRuleLogic();
            Assert.AreEqual(learningToSKIString, "Add a first aid video to the packin slip");
            Assert.AreNotEqual(learningToSKIString, "create a duplicate packing slip for royality department");
        }

        [TestMethod]
        public void PhysicalProductOrABookTest()
        {
            PhysicalProductOrABook physicalProductOrABook = new PhysicalProductOrABook();
            string physicalProductOrABookString = physicalProductOrABook.GetBusinessRuleLogic();
            Assert.AreEqual(physicalProductOrABookString, "Commission payment to the agent");
            Assert.AreNotEqual(physicalProductOrABookString, "create a duplicate packing slip for royality department");
        }
    }
}
