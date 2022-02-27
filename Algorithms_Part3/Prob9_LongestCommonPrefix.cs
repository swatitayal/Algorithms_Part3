using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob9_LongestCommonPrefix
    {
        static void Main9(string[] args)
        {
            //string[] A = { "Namesake", "Nayjdhfjsdhf", "Named", "Name"};
           //string[] A = { "geeksforgeeks", "geeks", "geek", "geezer"};
           string[] A = { "gesks", "freghj", "hsyeb", ""};
                       
            string result = findLCP(A);

            if (result.Length > 0)
            {
                Console.WriteLine("Longest prefix is: " + result);
            }
            else
            {
                Console.WriteLine("No matching prefix found!!");
            }
        }

        static string findLCP(string[] A)
        {
            int Total_words = A.Length;
            int minLength = A[0].Length;
            int index = 0;
            char key = '\n';
            int end = 0;

            for (int i = 1; i < Total_words; i++)
            {
                if (minLength > A[i].Length)
                {
                    minLength = A[i].Length;
                }
            }

            
            for (index = 0; index < minLength; index++)
            {
                key = A[0][index];
                for (int i = 1; i < Total_words; i++)
                {
                    if (A[i][index] != key)
                    {
                        end = 1;
                        break;
                    }
                }
                if (end == 1)
                    break;
            }

            string result = A[0].Substring(0, index);
            return result;
            
        }
    }
}
