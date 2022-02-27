using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob5_LongestCommonSubstring
    {
        static void Main5(string[] args)
        {
            //string str1 = "PING";
            //string str2 = "GINGER";

            //string str1 = "zxabcdezy";
            //string str2 = "yzabcdezx";

            //string str1 = "abcdxyz";
            //string str2 = "xyzabcd";

            string str1 = "";
            string str2 = "GINGER";

            findLCS(str1, str2);

        }

        static void findLCS(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;
                        
            int[,] record = new int[m+1, n+1];
            int maxLength = 0;
            int end = 0;

            if (m == 0 || n == 0)
            {
                Console.WriteLine("There could be no common substring for the given input!!");
                return;
            }

            for (int i = 0; i<= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        record[i, j] = 0;
                    }
                    
                    else if (str1[i-1] == str2[j-1])
                    {
                        record[i, j] = 1 + record[i - 1, j - 1];

                        if(record[i,j] > maxLength)
                        {
                            maxLength = record[i, j];
                            end = i;
                        }
                    }
                    else
                    {
                        record[i, j] = 0;
                    }
                    Console.Write(record[i,j] + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("The longest common substring of the two strings is: " + str1.Substring(end - maxLength , maxLength));
            Console.WriteLine("The length of the longest common substring is: " + maxLength);

        }
    }
}
