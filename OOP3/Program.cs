using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler'de newlenenen clasın referansı tutabilir.

            ICreditManager requirementCreditManager = new RequirementCreditManager();

            //ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager mortgageCreditManager = new MortgageCreditManager();


            //alternatif olarak paratmetre olarak gönderirken aşağıdaki gibi, new class ismi şeklindede kullanılabilir.
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RequestManager requestManager = new RequestManager();
            requestManager.MakeAnnApplication(new VehicleCreditManager(), new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});

            // yukarıdaki şekildede kullanılabilir. Newlenen logger kısmına bakabilirsin
            List<ICreditManager> creditManagers = new List<ICreditManager>() { mortgageCreditManager, new VehicleCreditManager()};

            //requestManager.CreditPreliminaryInformation(creditManagers);
            
            
        }
    }
}
