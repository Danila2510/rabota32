using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Первая задача 

            Console.Write("Enter size ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 20);
            int unic = 0;
            bool check = true;
            string buf_c = "", buf_uc = "", buf_unic = "";
            Console.Write("Array ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    buf_c += arr[i].ToString() + " ";
                else if (arr[i] % 2 != 0)
                    buf_uc += arr[i].ToString() + " ";
                unic = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (unic == arr[j])
                        check = false;
                }
                if (check)
                    buf_unic += unic.ToString() + " ";
                check = true;
            }
            Console.WriteLine("Even [0]\n odd [1]\n unique [2]", buf_c, buf_uc, buf_unic);
            #endregion

            #region Вторая задача

            Console.Write("\nEnter the maximum value ");
            int max = Convert.ToInt32(Console.ReadLine());
            string buf_2 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (max > arr[i])
                    buf_2 += arr[i].ToString() + " ";
            }
            Console.WriteLine($"Result {buf_2}");
            #endregion

            #region Третья задача

            Console.WriteLine("Enter a sequence of numbers ");
            string buf_3 = Console.ReadLine();
            string buf_3_arr = "";
            int count = 0, index = 0;
            for (int i = 0; i < arr.Length; i++)
                buf_3_arr += arr[i].ToString() + " ";
            for (int i = 0; i < buf_3_arr.Length; i++)
            {
                if (buf_3_arr.IndexOf(buf_3) > -1 + index)
                {
                    count++;
                    index = buf_3_arr.IndexOf(buf_3) + 1;
                }
            }
            Console.WriteLine($"Number of repetitions {count}");
            #endregion
        }
    }
}
