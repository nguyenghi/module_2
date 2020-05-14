using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BaiTapFileIO
{
    class Helper
    {
        public static int SumMatrix(int [,] matrix)
        {
            int sum = 0;
            for( int i= 0; i< matrix.GetLength(0); i++)
            {
                for( int j =0; j< matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[i, j];
                }
            }
            return sum;
        }
        public static int CountPrime(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (CheckPrime(matrix[i, j]))
                        count++;
                }
            }
            return count;
        }
        public static bool CheckPrime(int num)
        {
            if (num == 2)
                return true;
            if (num < 2)
                return false;
            for (int i = 3; i < num-1;i++)
            { 
                if( num %i ==0)
                    return false;
            }
            return true;
        }
        public static bool CheckOddNumber(int num)
        {
            if (num % 2 != 0)
                return true;
            return false;
        }
        public static int CountOddnumber(int [,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (CheckOddNumber(matrix[i,j]))
                        count++;
                }
            }
            return count;
        }
        public static int SumBoder(int [,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                    for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    {
                        sum = sum + matrix[0, j]+ matrix[matrix.GetLength(0)-1,j]
                            + matrix[i,0]+ matrix[i,matrix.GetLength(1)-1];
                    }
                }
            }
            return sum;
        }
        public static void ShowMatrixMul3( int[,] matrix,int mulnum)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                        matrix[i,j]= matrix[i, j]*mulnum;
                    
                }
            }
        }
    }
}
