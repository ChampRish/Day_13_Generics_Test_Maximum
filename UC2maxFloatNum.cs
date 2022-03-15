using System;

namespace UC2maxFloatNum
{
    class Program
    {
        public static double maxFloatNumber(double fNum, double sNum, double tNum)
        {
            if (fNum.CompareTo(sNum) > 0 && fNum.CompareTo(tNum) > 0 ||
                fNum.CompareTo(sNum) >= 0 && fNum.CompareTo(tNum) > 0 ||
                fNum.CompareTo(sNum) > 0 && fNum.CompareTo(tNum) >= 0)
            {
                return fNum;
            }
            if (sNum.CompareTo(fNum) > 0 && sNum.CompareTo(tNum) > 0 ||
                sNum.CompareTo(fNum) >= 0 && sNum.CompareTo(tNum) > 0 ||
                sNum.CompareTo(fNum) > 0 && sNum.CompareTo(tNum) >= 0)
            {
                return sNum;
            }
            if (tNum.CompareTo(fNum) > 0 && tNum.CompareTo(sNum) > 0 ||
                tNum.CompareTo(fNum) >= 0 && tNum.CompareTo(sNum) > 0 ||
                tNum.CompareTo(fNum) > 0 && tNum.CompareTo(sNum) >= 0)
            {
                return tNum;
            }
            return fNum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Greater Float Number is : " + Program.maxFloatNumber(1.5, 10.4, 7.4));
        }
    }
}
