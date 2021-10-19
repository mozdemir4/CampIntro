using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class RequestManager
    {
        //Method enjection
        public void MakeAnnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //başvuran bilgilerini değerlendirme

            //çeşitli işlemler

            creditManager.Calculate();
            for (int i = 0; i < loggerServices.Count; i++)
            {
                loggerServices[i].Log();
            }
        }

        // kredi ön bilgilendirmesi yap
        public void CreditPreliminaryInformation(List<ICreditManager> creditManagers)
        {
            for (int i = 0; i < creditManagers.Count; i++)
            {
                creditManagers[i].Calculate();
            }
        }
    }
}
