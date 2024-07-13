using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingInterviewQuestions.CustomSortingStrings
{
    public static class CustomSortString
    {
        public static List<string> valuesToSort;
        static CustomSortString()
        {
            
        }

        public static void CallStringSort()
        {
            valuesToSort.ForEach(val => Console.WriteLine(val.ToString()));

            Console.WriteLine("");
            Console.WriteLine("Sorted words...");
            Console.WriteLine("");
            ApplyCustomSort(valuesToSort);
        }

        private static void ApplyCustomSort(List<string> valuesToSort) 
        { 
            string temp = string.Empty;

            for (int i = 0; i < valuesToSort.Count; i++)
            {
                for(int j = 0; j < valuesToSort.Count; j++)
                {
                    if (string.Compare(valuesToSort[i], valuesToSort[j]) < 0)
                    {
                        temp = valuesToSort[i];
                        valuesToSort[i] = valuesToSort[j];
                        valuesToSort[j] = temp;
                    }
                }
            }

            foreach (string s in valuesToSort)
            {
                Console.WriteLine(s);
            }            
        }
    }
}
