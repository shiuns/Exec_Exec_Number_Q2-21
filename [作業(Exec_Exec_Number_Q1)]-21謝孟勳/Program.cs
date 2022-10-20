using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_Exec_Number_Q1___21謝孟勳
{
    //判斷某數值是不是質數
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數值: ");
            string input = Console.ReadLine();
            int number =Convert.ToInt32(input);
            int root = (int)Math.Ceiling(Math.Sqrt(number));
            
            for (int i = 2; i < root; i++)
            {
                if (number % i==0)
                {
                    Console.WriteLine("不是質數");
                    return;
                }
                
            }
            Console.WriteLine("是質數");
        }
    }
}
