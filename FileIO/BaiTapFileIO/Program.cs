using System;
using System.Text;
using System.IO;

namespace BaiTapFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathInput = @"G:\codegym\module2\FileIO\BaiTapFileIO\Files\InputData.txt";
            string pathOutput = @"G:\codegym\module2\FileIO\BaiTapFileIO\Files\OutputData.txt";
            int[,] matrix;
            int row, col, sum, countprime, countoddnumber, sumboder;

            using (StreamReader sr = File.OpenText(pathInput))
            {
                string line = "";
                line = sr.ReadLine();
                string[] rowcol = line.Split(" ");
                row = int.Parse(rowcol[0]);
                col = int.Parse(rowcol[1]);
                matrix = new int[row, col];
                int rowIndex = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] rows = line.Split(" ");
                    for (int i = 0; i < rows.Length; i++)
                    {
                        matrix[rowIndex, i] = int.Parse(rows[i]);
                    }
                    rowIndex++;
                }
                sum = Helper.SumMatrix(matrix);
                countprime = Helper.CountPrime(matrix);
                countoddnumber = Helper.CountOddnumber(matrix);
                sumboder = Helper.SumBoder(matrix);
               // Helper.ShowMatrixMul3( matrix,3);
            }

            using (StreamWriter sw = File.CreateText(pathOutput))
            {
                sw.WriteLine($"{row} {col}");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sw.Write($"{matrix[i, j]}\t");
                    }
                    sw.WriteLine();
                }
                sw.WriteLine($"Tong cua ma tran: {sum}");
                sw.WriteLine($"So nguyen to co trong ma tran:{countprime}");
                sw.WriteLine($"So le cos trong ma tran: {countoddnumber}");
                sw.WriteLine($"Tong duong vien {sumboder}");
                sw.WriteLine($"{row},{col}");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sw.Write($"{matrix[i, j]*3}\t");
                    }
                    sw.WriteLine(" ");
                }
            }
        }
    
    }
}
