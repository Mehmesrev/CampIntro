using System;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditManager konutCreditManager = new KonutCreditManager();
            CreditManager tasitCreditManager = new TasitCreditManager();
            CreditManager ihtiyacCreditManager = new IhtiyacCreditManager();

            //this line is   commented because (x)
            //LoggerService databaseLoggerService = new DatabaseLoggerService();
            LoggerService fileLoggerService = new FileLoggerService();

            //interface, onu implemente eden classın referansını tutabilir.
            List<LoggerService> allLoggers = new List<LoggerService> { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService() };


            ApplicationManager applicationManager = new ApplicationManager();
                                                                 //(x)
            applicationManager.DoApplication(konutCreditManager, allLoggers);

            List<CreditManager> Credits = new List<CreditManager>() {konutCreditManager, tasitCreditManager, ihtiyacCreditManager};
            //applicationManager.MakeCreditPreliminaryInformation(Credits);


        }
    }
}