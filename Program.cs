using System;

namespace UC1max3Integer
{
    class Program
    {
       

            //public static void toPrint(int[] inputArray)
            //{
            //    foreach(int element in inputArray)
            //    {
            //        Console.WriteLine(element);
            //    }
            //    Console.WriteLine("----------------------");
            //}

            public static int maxIntergerNumber(int fNum, int sNum,  int tNum)
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
            //int[] intArray = { 23, 54, 21, 67, 87 };
            //Program.toPrint(intArray);

            Console.WriteLine("Largest Integer value is : "+ Program.maxIntergerNumber(7,56,34));
           
        }
    }
}
