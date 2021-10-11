using System;

namespace lab4p2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        /// <summary>
        /// Returns true if the array is a square size, and contains only diagonal elements, this means that all non-diagonal values
        /// </summary>
        /// <param name="arr">a 2d integer array</param>
        /// <returns>Returns true if and only if the array is a square size, and contains only diagonal elements.</returns>
        public static bool IsDiagonal(int[,] arr)
        {
            if(arr.GetLength(0) != arr.GetLength(1))
            {
                return false;
            }
            else
            {
                for(int i = 0; i < arr.GetLength(0); i++)
                {
                    for(int j = 0; j < arr.GetLength(1); j++)
                    {
                        if(i == j)
                        {
                            continue;
                        }
                        else
                        {
                            if(arr[i,j] != 0)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
        }
    }
}
