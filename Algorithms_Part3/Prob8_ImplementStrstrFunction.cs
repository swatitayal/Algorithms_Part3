using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob8_ImplementStrstrFunction
    {
        static void Main8(string[] args)
        {
            string S = "pcomposed poser";
            string X = "poser";

            int position = strstr(S, X);

            if (position == -1)
            {
                Console.WriteLine("Substring not found!!");
            }
            else
            {
                Console.WriteLine("The substring '" + X + "' starts at index " + position + " of string " + S);
            }

        }

        static int strstr(string str1, string str2)
        {
            int n = str2.Length;
            
            if (n==0)
            {
                return -1;
            }

            int pos = findOccurence(str1, str2, 0);
            
            string match = "";

            while (match!= str2 && pos >= 0 && pos < str1.Length)
            {
                if (pos + str2.Length > str1.Length) //Check for overflow condition
                {
                    pos = -1;
                }
                else
                {
                    match = str1.Substring(pos, n);
                    
                    if (match == str2)              // substring is found.
                    {
                        break;
                    }
                    else
                    {
                        pos = findOccurence(str1, str2, pos + 1);
                    }
                }
            }

            return pos;
        }

        static int findOccurence(string s1, string s2, int start)
        {
            int pos = -1;
            for (int i = start; i<s1.Length; i++)
            {
                if (s1[i] == s2[0])
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
    }
}
