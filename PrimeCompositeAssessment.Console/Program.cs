using PrimeCompositeAssessment.Application;
using System;
using System.Reflection;

namespace PrimeCompositeAssessment
{   
    class Program
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            try
            {
                Console.Clear();

                Console.WriteLine(" Prints numbers from 1 to 100 ");

                var app = new PrimeCompositeApplication();

                app.GetNumbersFromRange(1, 100).ForEach(x =>
                 {
                     Console.WriteLine(x);
                 });

                Console.WriteLine("\n Press any key to exit!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }
    }
}
