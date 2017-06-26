using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter triangle : ");
            //int max = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < max; i++)
            //{
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}
            // triangletree(8);
            //Run();
            Console.Write("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine("{0}", Fibonacci(i));
            }
       
            //Array1();

            //Console.Write("Enter number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number for increment : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < number; i += num2)
            //{
            //    Console.WriteLine(i);
            //}

            //Triangle();

            //Random r = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int nums = r.Next(1, 100);
            //    if (IsExist(nums))
            //        i--;
            //    else
            //    {
            //        arr[i] = nums;
            //        Console.WriteLine(arr[i]);
            //    }
            //}
            //for (int x = 1; x < 8; x++)
            //{
            //    if (x > 5)
            //        break;
            //    Console.WriteLine(x);
            //}

           
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            TwoSum(n);
            //Array1();
           
        }

        public static int[] arr = new int[20];
        public static bool IsExist(int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    return true;
            }
            return false;
        }
        public static void Triangle()
        {
            Console.Write("Enter triangle size : ");
            int max = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }
           
        }
        public static void triangletree(int tri_size)
        {
            //Console.Write("Enter triangle size : ");
            //tri_size = Convert.ToInt32(Console.ReadLine());
            int x, y;
            for (y = 1; y <= tri_size; y++)
            {
                for (x = 0; x < tri_size - y; x++)
                {
                    Console.Write(' ');
                }
                for (x = (2 - y); x < (2 - y) + (2 * y - 1); x++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public static void Run()
        {
            Console.WriteLine("Hello World");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("BLACK");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("JACK");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BLACK JACK");
                }
                else
                    Console.WriteLine(i);
            }
        }
        public static void Array1()
        {
            int[] Array = { 11, 33, 5, -3, 19, 8, 49 };
            int temp;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
            //Console.Write("Sorted:");
            foreach (int sort in Array)
                Console.Write("{0} ", sort);
        }
        public static int Fibonacci(int n)
        {
                        //return a;
            int a = 1;
                int b = 2;
                for (int i = 1; i < n; i++)
                {
                    int num = a;
                    a = b;
                    b = num + a;
                }
                return a;
        }
        public static void TwoSum(int num)
        {
            int[] a = new int[] { 1, 5, 8, 9, 3, 0 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == num)
                    {
                        Console.WriteLine(a[i] + " " + a[j]);
                    }
                }
            }
            //return a[n];
        }
        public static int Count(int[] a)
        {
            int count =0;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                    for (int k = j + 1; k < a.Length; k++)
                        if (a[i] + a[j] + a[k] == 0)
                            count++;
            return count;
        }
    }
}
