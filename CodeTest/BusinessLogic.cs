using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
     interface IBusinessLogic
    {
        string  GetBusinessRuleLogic();
    }
     public class PhysicalProduct : IBusinessLogic
    {
        //write a logic for, packing slip for shipping
        public string GetBusinessRuleLogic()
        {
            return "packing slip for shipping";
        }
    }
     public class Book : IBusinessLogic
    {
        //write a logic for, create a duplicate packing slip for royality department
        public string GetBusinessRuleLogic()
        {
            return "create a duplicate packing slip for royality department";
        }
    }
     public class Membership : IBusinessLogic
    {
        //write a logic for, Activate the Membership
        public string GetBusinessRuleLogic()
        {
            return "Activate the Membership";
        }
    }
     public class Upgrade : IBusinessLogic
    {
        //write a logic for, Applying for Upgrade
        public string GetBusinessRuleLogic()
        {
            return "Applying for Upgrade";
        }
    }
     public class MembershipOrUpgrade : IBusinessLogic
    {
        //write a logic for, email to the owner and inform them of activation / Upgrade
        public string GetBusinessRuleLogic()
        {
            return "email to the owner and inform them of activation / Upgrade";
        }
    }
     public class LearningToSKI : IBusinessLogic
    {
        //write a logic for, Add a first aid video to the packin slip
        public string GetBusinessRuleLogic()
        {
            return "Add a first aid video to the packin slip";
        }
    }
     public class PhysicalProductOrABook : IBusinessLogic
    {
        //write a logic for, Commission payment to the agent
        public string GetBusinessRuleLogic()
        {
            return "Commission payment to the agent";
        }
    }
}
