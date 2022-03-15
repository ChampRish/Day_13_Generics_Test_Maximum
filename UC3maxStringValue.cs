using System;

namespace UC3maxStringValue
{
    class Program
    {
        public static string maxStringValue(string fStr, string sStr, string tStr)
        {
            if (fStr.CompareTo(sStr) > 0 && fStr.CompareTo(tStr) > 0 ||
                fStr.CompareTo(sStr) >= 0 && fStr.CompareTo(tStr) > 0 ||
                fStr.CompareTo(sStr) > 0 && fStr.CompareTo(tStr) >= 0)
            {
                return fStr;
            }
            if (sStr.CompareTo(fStr) > 0 && sStr.CompareTo(tStr) > 0 ||
                sStr.CompareTo(fStr) >= 0 && sStr.CompareTo(tStr) > 0 ||
                sStr.CompareTo(fStr) > 0 && sStr.CompareTo(tStr) >= 0)
            {
                return sStr;
            }
            if (tStr.CompareTo(fStr) > 0 && tStr.CompareTo(sStr) > 0 ||
                tStr.CompareTo(fStr) >= 0 && tStr.CompareTo(sStr) > 0 ||
                tStr.CompareTo(fStr) > 0 && tStr.CompareTo(sStr) >= 0)
            {
                return tStr;
            }
            return fStr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Biggest String Value is : " + Program.maxStringValue("Apple", "Mango", "Banana"));
        }
    }
}
