using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareOregonTest
{
    public class Program
    {
        static void Main(string[] args)
        {

            
        }

        public int CalculateFibonacci(int position)
        {
            int first = 1;
            int second = 1;

            for (int i = 0; i < position; i++)
            {
                int temp = first;
                first = second;
                second = temp + second;
                Console.WriteLine("position " + i + ": value " + second);
            }
            return first;
        }
    }
}
