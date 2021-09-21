using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOExamples
{
    public class Examples
    {
        //This method takes the same amount of time to run no matter how large n is. O(1)
        public int FirstValue(int[] n)
        {
            return n[0];       //returns the first value of n no matter what.
        }

        //The time this method takes scales linearly with the size of n. O(n)
        public string AllValues(int[] n)
        {
            string ret = "";
            foreach (int i in n)     //This foreach loop takes a set amount of time longer for each value of n.
            {
                ret += $"{i}, ";
            }
            return ret;
        }

        //The time this method takes scales quadratically with the size of n. O(n^2)
        public int FindDistance(int[] n, int target, int target2)
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[i] == target && n[j] == target2)
                    {
                        return Math.Abs(i - j); //This could return after only one loop, but its worst-case scenario is still quadratic.
                    }
                }
            }
            return -1;
        }
    }
}
