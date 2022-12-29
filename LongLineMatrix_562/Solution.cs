using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongLineMatrix_562
{
    public class Solution
    {

        public int LongestLine(int[][] mat)
        {
            // store the largest count seen so far
            int count = 0;

            int row = mat.Length; 
            int col = mat[0].Length; 
            int maxCount = Math.Max(row, col);
            bool is1D = row == 1 || col == 1;

            int hCount = 0;
            int[] vCount = new int[col];
            int[,] dp = new int[row + col, 2];

            int d = 0; //0 for diagonal
            int a = 1; //1 for antidiagonal

            // traverse the matrix and update the dp array
            for (int r = 0; r < row; r++)
            {
                hCount = 0;
                for (int c = 0; c < col; c++)
                {
                    if (count == maxCount)
                        return count;

                    if (mat[r][c] == 1)
                    {
                        // update the horizontal count
                        hCount = hCount + 1;
                        count = Math.Max(count, hCount);

                        // update the vertical count
                        vCount[c] = vCount[c] + 1;
                        count = Math.Max(count, vCount[c]);

                        // update the diagonal count,
                        //if not the last of first row and first of last col.
                        if (!is1D && !((r == 0 && c == col - 1)
                                || (c == 0 && r == row - 1)))
                        {
                            int dr = (r <= c) ? c - r : ((col - 2) + (r - c));
                            dp[dr, d] = dp[dr, d] + 1;
                            count = Math.Max(count, dp[dr, d]);
                        }
                        // update the anti-diagonal count,
                        //if not the first and last element.
                        if (!is1D && !((r == 0 && c == 0) 
                            || (c == col - 1 && r == row - 1)))
                        {
                            int ar = r + c;
                            dp[ar, a] = dp[ar, a] + 1;
                            count = Math.Max(count, dp[ar, a]);
                        }
                    }
                    else
                    {
                        // reset  count
                        hCount = 0;
                        vCount[c] = 0;
                        if (!is1D && !((r == 0 && c == col - 1)
                            || (c == 0 && r == row - 1)))
                        {
                            int dr = (r <= c) ? c - r : ((col - 2) + (r - c));
                            dp[dr, d] = 0;
                        }
                        if (!is1D && !((r == 0 && c == 0) 
                            || (c == col - 1 && r == row - 1)))
                        {
                            int ar = r + c;
                            dp[ar, a] = 0;
                        }
                    }
                }
            }

            return count;
        }

    }
}
