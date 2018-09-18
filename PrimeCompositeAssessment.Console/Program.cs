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

                do
                {

                    Console.WriteLine("Enter your choice in below \n " +
                                      "1) Print range of numbers \n " +
                                      "2) Print Prime text in place of prime numbers in a range \n " +
                                      "3) Print Composite text in place of Composite numbers in a range which are not even");

                    int typesetter = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                    Console.WriteLine("Enter starting number in a range");
                    long from = long.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                    Console.WriteLine("Enter last number in a range");
                    long to = long.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                    var app = new PrimeCompositeApplication();

                    switch (typesetter)
                    {

                        case 1:
                            //1. print only numbers in a range of 1 to 100
                            Console.Clear();
                            app.GetNumbersFromRange(from, to).ForEach(x =>
                            {
                                Console.WriteLine(x);
                            });
                            break;
                        case 2:
                            //2. print prime text in place of prime number in a given range
                            Console.Clear();
                            app.GetListWithReplacedPrimeNumberWithPrimeText(from, to).ForEach(x =>
                            {
                                Console.WriteLine(x);
                            });
                            break;
                        case 3:
                            //3 print Composite in place of 
                            Console.Clear();
                            app.GetListWithReplacedCompositeNumberAndNotEvenWithCompositeText(from, to).ForEach(x =>
                            {
                                Console.WriteLine(x);
                            });
                            break;

                    }

                    Console.WriteLine("\n Do to continue Press Y , Press N to exit?");

                } while (Console.ReadLine() != "N");
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }
    }
}
