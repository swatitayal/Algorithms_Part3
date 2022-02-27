using System;
using System.Collections.Generic;

namespace Assignment6
{
    class LongestPalindromimSubstring
    {
        static void Main1(string[] args)
        {
            //string S = "babad";               //odd palidrome
            //string S = "cacdacbbcadabc";      //even palindrome
            //string S = "aabcabdd";            //palindrome at beginning
            string S = "badccc";               //palindrome at the end

            findLongestPalindrome(S);
        }

        static void findLongestPalindrome(string str)
        {
            int n = str.Length;
            string curr_str, max_str = "";
            int maxLength = 0;
            for (int i = 0; i<n; i++)
            {
                curr_str = expand(str, i, i);          //Find the longest odd length palindrome with str[i] as a midpoint.

                if (curr_str.Length > maxLength)
                {
                    maxLength = curr_str.Length;
                    max_str = curr_str;
                }

                curr_str = expand(str, i, i + 1);   //Find the longest even length palindrome with str[i] & str[i+1] as midpoints.
                if (curr_str.Length > maxLength)
                {
                    maxLength = curr_str.Length;
                    max_str = curr_str;
                }
            }
            Console.WriteLine("The longest palidromic substring of '" + str + "' is: " + max_str);
        }

        static string expand(string str, int low, int high)
        {
            int n = str.Length;

            while(low >= 0 && high < n && str[low] == str[high] )
            {
                low--;
                high++;
            }

            int start = low + 1;
            int end = high - 1;
            int length = end - start + 1;

            return str.Substring(start, length);
        }
    }
}
