using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessLogic physicalProduct = new PhysicalProduct();
            IBusinessLogic book = new Book();
            IBusinessLogic membership = new Membership();
            IBusinessLogic upgrade = new Upgrade();
            IBusinessLogic membershipOrUpgrade = new MembershipOrUpgrade();
            IBusinessLogic learningToSKI = new LearningToSKI();
            IBusinessLogic physicalProductOrABook = new PhysicalProductOrABook();

            string physicalProductString = physicalProduct.GetBusinessRuleLogic();
            string bookString = book.GetBusinessRuleLogic();
            string membershipString = membership.GetBusinessRuleLogic();
            string upgradeString = upgrade.GetBusinessRuleLogic();
            string membershipOrUpgradeString = membershipOrUpgrade.GetBusinessRuleLogic();
            string learningToSKIString = learningToSKI.GetBusinessRuleLogic();
            string physicalProductOrABookString = physicalProductOrABook.GetBusinessRuleLogic();

            Console.WriteLine(physicalProductString);
            Console.WriteLine(bookString);
            Console.WriteLine(membershipString);
            Console.WriteLine(upgradeString);
            Console.WriteLine(membershipOrUpgradeString);
            Console.WriteLine(learningToSKIString);
            Console.WriteLine(physicalProductOrABookString);
            Console.ReadKey();

        }
    }
}
