using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Q1
    {
        public void sol1()
        {
            double year = 1;
            double deb = 1000;
            double ac = 0.05;
            double tot = 1000;
             tot = tot + (deb * ac);
            Console.WriteLine("Year   Interest for the year                          End of the Year amount");
            Console.WriteLine("\n");
            Console.WriteLine($"{year}        {deb}*{ac}={deb*ac}                                 {tot}");


            while (tot<100000)
            {
                year++;
                double y = tot * ac;
                double ser = tot;
                tot = tot + y;
                Console.WriteLine($"{year}        {ser}*{ac}={ser*ac}                              {tot}");
            }
            

        }
    }
}
