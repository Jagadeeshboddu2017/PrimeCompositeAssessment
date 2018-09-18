namespace PrimeCompositeAssessment.Infrastructure.Helpers
{
    public static class NumberExtensions
    {
        /// <summary>
        /// checks number is even or not
        /// </summary>
        /// <param name="i">long value</param>
        /// <returns>returns bool, whether given number is even or not</returns>
        public static bool IsEven(this long i)
        {
            return ((i % 2) == 0);
        }

        /// <summary>
        /// checks number is prime or not
        /// </summary>
        /// <param name="i"></param>
        /// <returns>returns bool, whether given number is prime or not</returns>
        public static bool IsPrimeNumber(this long i)
        {
            int flag = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    flag++;
                    if (flag > 2)
                        break;
                }
            }
            if (flag == 2)
                return true;
            return false;
        }
    }
}
