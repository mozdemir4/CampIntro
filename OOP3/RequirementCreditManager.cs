using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //ihtiyaç kredisi
    class RequirementCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("consumer loan payment plan calculated");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
