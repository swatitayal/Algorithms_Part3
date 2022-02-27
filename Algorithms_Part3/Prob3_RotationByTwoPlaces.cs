using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class Prob3_RotationByTwoPlaces
    {
        static void Main3(string[] args)
        {
            string a = "amazon";
            //string b = "azonam";
            //string b = "onamaz";
            string b = "odfa";

            getResult(a, b);
        }

        static void getResult(string strA, string strB)
        {
            int nA = strA.Length;
            int nB = strB.Length;

            if(nA != nB)
            {
                Console.WriteLine("False!! \nString A and String B have different lengths.");
                return;
            }
            
            string anti = strB.Substring(nB - 2) + strB.Substring(0, nB - 2);
            
            if (anti == strA)
            {
                Console.WriteLine("True!! \nString A can be obtained by rotating string B by two places in anti-clockwise direction.");
            }
            else
            {
                string clock = strB.Substring(2) + strB.Substring(0, 2);

                if(clock == strA)
                {
                    Console.WriteLine("True!! \nString A can be obtained by rotating string B by two places in clockwise direction.");
                }
                else
                {
                    Console.WriteLine("False!! \nString A cannot be obtained by rotating string B by two places in either direction.");
                }
            }
        }
    }
}
