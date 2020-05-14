using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileDemo
{
    class MatrixIODemo
    {
        public static void Main()
        {
            string pathInput = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\input.txt";
            string pathOutput = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\output.txt";

            int[,] matrix;
            int row, col;
            using (StreamReader sr = File.OpenText(pathInput))
            {
                string line = "";
                line = sr.ReadLine();
                string[] rowcol = line.Split(" ");
                row = int.Parse(rowcol[0]);
                col = int.Parse(rowcol[1]);
                matrix = new int[row, col];
                int rowIndex = 0;
                while((line = sr.ReadLine()) != null)
                {
                    string[] rows = line.Split(" ");
                    for(int i = 0; i < rows.Length; i++)
                    {
                        matrix[rowIndex, i] = int.Parse(rows[i])*2;
                    }
                    rowIndex++;
                }
            }

            using (StreamWriter sw = File.CreateText(pathOutput))
            {
                sw.WriteLine($"{row} {col}");
                for(int i = 0; i < row; i++)
                {
                    for(int j = 0; j< col; j++)
                    {
                        sw.Write($"{matrix[i, j]}\t");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
