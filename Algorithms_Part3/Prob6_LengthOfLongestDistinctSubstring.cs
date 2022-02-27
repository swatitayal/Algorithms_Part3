using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob6_LengthOfLongestDistinctSubstring
    {
        static void Main6(string[] args)
        {
            //string S = "ABDABCD";
            //string S = "AABCDCCABCDEE";
            string S = "AABCDCCABCDEEABCDEF";
            //string S = "ABACDAZXY";
            //string S = "GEEKSFORGEEKS";
            //string S = "BBBBBB";
            //string S = "";
            //string S = "ABDEFGABEFCXZYTGAB";

            findLength(S);

        }

        static void findLength(string str)
        {
            int n = str.Length;
            int start = 0;
            int max_length = 0;
            int curr_start = 0;
            int curr_length = 0;
            Dictionary<char, int> D = new Dictionary<char, int>();

            if(n<2)
            {
                Console.WriteLine("Please enter a valid string.");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (D.ContainsKey(str[i]))
                {
                    curr_start = Math.Max((D[str[i]] + 1), curr_start);
                    curr_length = i - curr_start + 1;
                    D[str[i]] = i;
                }
                else
                {
                    D.Add(str[i], i);
                    curr_length++;
                }

                if (curr_length > max_length)
                {
                    max_length = curr_length;
                    start = curr_start;
                }
            }
            string S = str.Substring(start, max_length);
            Console.WriteLine("The length of the longest substring with distinct elements is: " + max_length);
            Console.WriteLine("The substring is: " + S);
        }
    }
}
