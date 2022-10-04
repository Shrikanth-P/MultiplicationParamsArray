using System;

namespace multiplicationParamsArray
{
    class multiplicationParamsArray
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Params Array Multiplication : ");
            int res = multiplication(1,2,3);
            Console.WriteLine("res : "+res);
            int res1 = multiplication(1, 2, 3,4);
            Console.WriteLine("res1 : " + res1);
            int res2 = multiplication(1, 2, 3,4,5);
            Console.WriteLine("res2 : " + res2);
            int res3 = multiplication(1, 2, 3,4,5,6);
            Console.WriteLine("res3 : " + res3);
            int res4 = multiplication(10,20,30,40,50);
            Console.WriteLine("res4 : " + res4);
        }
        public static int multiplication(params int[] arr)
        {
           int product = 1;
           for(int i = 0; i < arr.Length; i++)
            {
                product*= arr[i];
            }
           return product;
        }
    }
}