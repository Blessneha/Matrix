using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Q2
    {

        public void sol2()
        {
            Console.WriteLine("Enter 3*# values :");
            int[,] arr = new int[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());   
                }
            }
            Console.WriteLine("The values are:");
            for (int i = 0; i < 3;i++)
            {
                for (int j = 0; j < 3;j++)
                {
                    Console.Write(arr[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
