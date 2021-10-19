using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // konut kredisi
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Home loan payment plan calculated");
        }

        public void DoIt()
        {
            throw new NotImplementedException();
        }
    }
}
