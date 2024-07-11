using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingInterviewQuestions.CustomSortingNumbers
{
    public static class CustomSort
    {
        public static List<int> listValues;
        static CustomSort()
        {
          //This is a static constructor. We can initialize values here only once.
        }
        public static void CallSort()
        {
            listValues.ForEach(iValue => Console.WriteLine(iValue.ToString()));

            listValues.ApplyCustomSort();

            Console.WriteLine("");
            Console.WriteLine("Sorted numbers...");
            Console.WriteLine("");
            for (int i = 0; i < listValues.Count; i++)
            {
                Console.WriteLine(listValues[i].ToString());
            }
        }

        private static void ApplyCustomSort(this List<int> valuesToSort)
        {
            for (int iCount = 0; iCount < valuesToSort.Count; iCount++)
            {
                for (int jCount = 0; jCount < valuesToSort.Count; jCount++)
                {
                    if (valuesToSort[iCount] < valuesToSort[jCount])
                    {
                        int tempValue = valuesToSort[iCount];
                        valuesToSort[iCount] = valuesToSort[jCount];
                        valuesToSort[jCount] = tempValue;
                    }
                }
            }
        } 
        
       
    }
}
