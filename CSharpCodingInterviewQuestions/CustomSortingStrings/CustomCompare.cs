using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodingInterviewQuestions.CustomSortingStrings
{

    /// <summary>
    /// Custom program to compare two strings. Returns 0 when both are equal, 1 when first string > second string and -1 when first string < second string
    /// </summary>
    public class CustomCompare
    {      
        private static int VbCompare(string firstString, string secondString)
        {           
            Dictionary<char, int> allAlphabets = new Dictionary<char,int>();

            for (int i = 0; i < 26; i++)
            {
                allAlphabets.Add((char)(97 + i), i);
            }

            int newValue1 = 0;
            int newValue2 = 0;

            foreach(char c in firstString.ToLower())
            {
                if (allAlphabets.ContainsKey(c))
                {
                    newValue1 += allAlphabets[c];
                }
            }

            foreach(char c in secondString.ToLower())
            {
                if (allAlphabets.ContainsKey(c))
                {
                    newValue2 += allAlphabets[c];
                }
            }

            if (newValue1 > newValue2)
            {
                //  Console.WriteLine("{0} > {1}", firstString, secondString);
                return 1;
            }
            else if (newValue1 < newValue2)
            {
                // Console.WriteLine("{0} < {1}", firstString, secondString);
                return -1;
            }
            else
            {
                //    Console.WriteLine("Both are equal");
                return 0;
            }          
        }

        public static int CompareTwoStrings(string firstValue, string secondValue)
        {    
            return VbCompare(firstValue, secondValue);
        }
    }
}
