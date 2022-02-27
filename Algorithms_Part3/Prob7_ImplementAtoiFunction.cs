using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob7_ImplementAtoiFunction
    {
        static void Main7(string[] args)
        {
            string S = "-0989";

            int result = atoiString(S);
            
            if (result == -2)
            {
                Console.WriteLine("String is empty!!");
            }
            else if(result == -1)
            {
                Console.WriteLine("Invalid string!!");
            }
            else
            {
                Console.WriteLine("The result is: " + result);
            }
            
        }

        static int atoiString(string str)
        {
            int n = str.Length;
            int number = 0;
            int i = 0;
            int sign = 1;

            if(n==0)
            {
                return -2;
            }

            if(str[0] == '-')
            {
                sign = -1;
                i++;
            }

            for (; i < n; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    number = number * 10  + (str[i] - '0') ;
                }
                else
                {
                    return -1;
                }
            }
            return number*sign;
        }
    }
}

