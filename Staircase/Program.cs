using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            char[,] array = new char[n,n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    array[i, j] = ' ';
                }
            }
            for(int i = 0; i < n ; i++)
            {
                for(int j = n-1; j >= n-i-1; j--)
                {
                    array[i, j] = '#';
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
