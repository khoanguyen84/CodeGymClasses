using System;
using System.Collections;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Input your number:");
            // var number = int.Parse(Console.ReadLine());
            // int[] arr = new int[number];
            // Random rnd = new Random();
            // int count = 0;
            // while(count < number){
            //     var n = rnd.Next(1, 11);
            //     if(Array.IndexOf(arr, n) == -1){
            //         arr[count] = n;
            //         count++;
            //     }
            // }
            
            // for(var i = 0; i < number; i++){
            //     Console.WriteLine("arr[" + (i+1) + "] = "+ arr[i]);
            // }

            //generate multi array
            Console.Write("Input number of row:");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Input number of column:");
            int col = int.Parse(Console.ReadLine());

            int[][] matrix = new int[row][];
            for(int i = 0; i < row ; i++){
                int[] arr = new int[col];
                Random rnd = new Random();
                for(int j = 0; j< col; j++){
                    arr[j] = rnd.Next(1,100);
                }
                matrix[i] = arr;
            }
             for(int i = 0; i < row ; i++){
                for(int j = 0; j< col; j++){
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            int[,] matrix1 = new int[row, col];
            for(int i = 0; i < row ; i++){
                Random rnd = new Random();
                for(int j = 0; j< col; j++){
                    matrix1[i,j] = rnd.Next(1,100);
                }
            }
            for(int i = 0; i < row ; i++){
                for(int j = 0; j< col; j++){
                    Console.Write(matrix1[i,j] + " ");
                }
                Console.WriteLine();
            }

            int[][] a = new int[2][]{new int[]{1,2,3}, new int[]{1,2,3}};
            int [,] b = {{1,2,3},{1,2,3}};
        }
    }
}
