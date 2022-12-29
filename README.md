# Longest Line of Consecutive One in Matrix

Given an m x n binary matrix mat, return the length of the longest line of consecutive one in the matrix.

The line could be horizontal, vertical, diagonal, or anti-diagonal.

Constraints:

m == mat.length

n == mat[i].length

1 <= m, n <= 104

1 <= m * n <= 104

mat[i][j] is either 0 or 1.

Sample Input: 

mat = [[0,1,1,0],[0,1,1,0],[0,0,0,1]]

Output: 3


In the dynamic programming solution, the dp array is used to store the counts of the longest lines of consecutive 1s along each direction as we traverse the input matrix.

When we reach a new element in the input matrix, we update the dp array by considering the value of the element and the values in the dp array for the previous elements.

Complexity
Time complexity:
O(mn). The entire matrix is traversed once only

Space complexity:
O(n+m). dp array of size 2(n+m) for the diagonals and array of size n , where n is the number of columns for vertical lines.
