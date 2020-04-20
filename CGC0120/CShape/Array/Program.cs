using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3, 4};
            // 4
            // 100
            // {1,2,3,4,100}
            // 0
            // 100
            // {1,2,100,3,4}
            int[] arr2 = new int[5];
            int a  = arr1[0];
            arr1[1] = 10;

            int size = 10;
            int[] arr3 = new int[size];

            //create random array
            Random rnd = new Random();
            // for(var i =0; i< size; i++){
            for(var i =0; i< arr3.Length;i++){
                arr3[i] = rnd.Next(1,20);
            }

            //read array
            for(var i=0;i<arr3.Length;i++){
                Console.Write("{0} ", arr3[i]);
            }
            Console.WriteLine();
            
            //add new element into array
            Console.Write("input position: ");
            var pos = int.Parse(Console.ReadLine());
            if(pos >=0 && pos <= arr3.Length){
                Console.Write("input value: ");
                var val = int.Parse(Console.ReadLine());
                Array.Resize(ref arr3, arr3.Length + 1);
                for(var i = arr3.Length -1; i> pos; i--){
                    arr3[i] = arr3[i-1];
                }
                arr3[pos] = val;
            }

            //read array
            for(var i=0;i<arr3.Length;i++){
                Console.Write("{0} ", arr3[i]);
            }

            Console.ReadKey();
        }
    }
}
