using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob2_RemoveAdjacentDuplicateCharacters
    {
        static void Main2(string[] args)
        {
           //string str = "azxxzy";
           //string str = "caaabbbbcddd";
           // string str = "acaaabbbacdddd";
            //string str = "bcaaacbdddaacc";
            string str = "DBAABDAB";


            string result = removeAdjacentDuplicates(str);

            if (result.Length > 0)
            {
                Console.WriteLine("The final string is: " + result);
            }
            else
            {
                Console.WriteLine("The final string is empty!!!");
            }

        }

        static string removeAdjacentDuplicates(string A)
        {
            int n = A.Length;
            Stack<char> S = new Stack<char>();
            S.Push(A[0]);
            char temp = '\n';
            string result = "";
            string str = "";

            for (int i = 1; i < n; i++)
            {
                if (A[i] == S.Peek())
                {
                    while (S.Peek() == A[i] && i < n - 1)
                    {
                        i++;
                    }

                    temp = S.Pop();

                    if (temp != A[i])
                    {
                        S.Push(A[i]);
                    }
                }
                else
                {
                    S.Push(A[i]);
                }
            }

            while (S.Count != 0)
            {
                result = result + S.Pop();
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                str = str + result[i];
            }

            if (str.Length == n || str.Length == 0)
            {
                return str;
            }
            else
            {
                Console.WriteLine("String after this iteration: " + str);
                return removeAdjacentDuplicates(str);
            }
        }
    }
}
