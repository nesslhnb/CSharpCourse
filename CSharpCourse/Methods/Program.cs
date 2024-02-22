using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add(number1,number2);
            Console.WriteLine(result);

        }
        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }


    }
}
