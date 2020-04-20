using System;

namespace ArrayExample
{
    class Array2
    {
        public static void Main(String[] agrs)
        {
            int row = 10;// InputNumber();
            int col = 10;// InputNumber();
            int[,] arr2 = CreateArray2(row, col);
            PrintArray2(arr2);
            //Console.ReadKey();
        }

        public static int InputNumber(){
            Console.Write("Input value: ");
            return int.Parse(Console.ReadLine());
        }
        public static int[,] CreateArray2(int row, int col){
            int[,] arr2 = new int[row, col];
            Random rnd = new Random();
            
            for(int i=0; i< row;i ++){
                for(int j=0; j< col;j++){
                    arr2[i,j] = rnd.Next(40,90);
                }
            }

            return arr2;
        }

        public static void PrintArray2(int[,] arr2){
            for(int i=0; i< arr2.GetLength(0); i++){
                for(int j=0; j< arr2.GetLength(1); j++){
                    Console.Write("{0} ", arr2[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}