using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob4_RomanToInteger
    {
        static void Main4(string[] args)
        {
           //string S = "XLIV";
          // string S = "2";
           string S = "MCMIV";
           //string S = "MMMDCCXCIV";

            int result = convertRoman(S);
            if (result == -1)
            {
                Console.WriteLine("Invalid String!!");
            }
            else
            {
                Console.WriteLine("The integer for the roman number '" + S + "' is: " + result);
            }
        }

        static int convertRoman(string str)
        {
            int n = str.Length;
            int prev = getInteger(str[n - 1]);
            int total = prev;
            int curr = 0;

            for (int i = n-2; i>=0; i--)
            {
                curr = getInteger(str[i]);
                if (curr >= prev)
                {
                    total = total + curr;
                }
                else
                {
                    total = total - curr;
                }
                prev = curr;
            }
            return total;
        }

        static int getInteger(char roman)
        {
            switch (roman)
            {
                case 'I':
                    return 1;

                case 'V':
                    return 5;

                case 'X':
                    return 10;

                case 'L':
                    return 50;
                    
                case 'C':
                    return 100;
                    
                case 'D':
                    return 500;
                    
                case 'M':
                    return 1000;
                    
                default:
                    return -1;
            }

        }
    }
}
