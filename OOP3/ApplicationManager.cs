using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{   //BaşvuruManager
    class ApplicationManager
    {   //Method Injection
        public void DoApplication(CreditManager creditManager, List<LoggerService> loggerServices)
        {
            //Bu kod sadece bir class için çalışır.
            //KonutCreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Calculate();

            //BU kod ise tüm İnheritance(miras) alan sınıflarda çalışır.
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void MakeCreditPreliminaryInformation(List<CreditManager> credits) 
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
