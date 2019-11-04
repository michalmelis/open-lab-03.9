using System;

namespace open_lab_03._9
{
    class Program
    {
        public static bool IsPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                {
                    return false;
                }
            return true;
        }
    }
}
