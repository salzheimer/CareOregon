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

            Console.WriteLine("Input the Fibonacci position you would like to see the value of");

            int desiredPositon;
            int.TryParse(Console.ReadLine(), out desiredPositon);

            var p = new Program();
            Console.WriteLine(String.Format("The value at position {0} = {1}", desiredPositon, p.CalculateFibonacci(desiredPositon)));
        }
        //Calculate Fibonacci squence up to inputted position were first number in squence is 1. s
        public int CalculateFibonacci(int position)
        {
            int first = 1;
            int second = 1;

            for (int i = 0; i < position; i++)
            {
                int temp = first;
                first = second;
                second = temp + second;

            }
            return first;
        }
    }
}
