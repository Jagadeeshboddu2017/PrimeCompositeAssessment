using System;
using System.Collections.Generic;
using System.Reflection;

namespace PrimeCompositeAssessment.Application
{
    public class PrimeCompositeApplication
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// GetNumbersFromRange takes range values and returns list of values which are in a given range 
        /// </summary>
        /// <param name="from"> from is statring value for a numbers range</param>
        /// <param name="to"> to is end value for a numbers range</param>
        /// <returns>list of values which are in a given range</returns>
        public List<long> GetNumbersFromRange(long from, long to)
        {
            Log.Info($"GetNumbersFromRange started with range from {@from} to {@to}");
            var rtnList = new List<long>();

            try
            {
                for (long i = from; i <= to; i++)
                    rtnList.Add(i);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }

            return rtnList;
        }

    }
}
