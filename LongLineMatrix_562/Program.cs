using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongLineMatrix_562
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] mat = new int[][]{
                //new int[] { 0},
                //new int[] { 0},
                //new int[] { 0},
                //new int[] { 0},
                //new int[] { 0}

                //new int[] { 0, 1, 0},
                //new int[] { 0, 1, 0},
                //new int[] { 0, 1, 0},
                //new int[] { 0, 1, 0},
                //new int[] { 0, 1, 0}

                new int[] { 0,1,0,1,1 },
                new int[] { 1,1,0,0,1 },
                new int[] { 0,0,0,1,0 },
                new int[] { 1,0,1,1,1},
                new int[] { 1,0,0,0,1}


                //new int[] { 0, 0, 1, 0, 0},
                //new int[] { 0, 0, 0, 1, 0},
                //new int[]{  0, 0, 0, 0, 1},
                //new int[]{  0, 0, 0, 0, 0},
                //new int[]{  0, 0, 0, 0, 0}
            };


            int r = s.LongestLine(mat);
        }
    }
}
