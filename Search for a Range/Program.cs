//https://leetcode.com/problems/search-for-a-range/
//Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] array = { 5, 7, 7, 8, 8, 10 };
            int[] ans = p.SearchRange(array, 8);

            Console.WriteLine("answer: [" + ans[0] + "," + ans[1] + "]");

            Console.Read();
        }

        public int[] SearchRange(int[] nums, int target)
        {
            // search "target" using binary search.
            // pp = target found at nums[p], qq = target found at nums[q]. :/
            int p = 0, q = nums.Length - 1;
            bool pp = false, qq = false;

            // loop breaked while p and q are found, p eqauls q is allowed.
            while (!(pp & qq))
            {
                // nothing found, break the loop
                if (p >= nums.Length)
                {
                    p = -1;
                    q = -1;
                    break;
                }

                // if p is found, there's no need to run code in the block, it can saves some seconds to execute.
                if (!pp)
                {
                    if (nums[p] != target)
                    {
                        p++;
                    }
                    else
                    {
                        //Console.WriteLine("p=" + p);
                        pp = true;
                    }
                }

                if (!qq)
                {
                    if (nums[q] != target)
                    {
                        q--;
                    }
                    else
                    {
                        //Console.WriteLine("q=" + q);
                        qq = true;
                    }
                }
            }

            return new int[] { p, q };
        }
    }
}
