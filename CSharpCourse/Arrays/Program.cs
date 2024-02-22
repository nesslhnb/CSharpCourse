using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studens = new string[3];
            studens[0] = "Esra";
            studens[1] = "Arslan";
            studens[2] = "Neslihan";
            foreach (var student in studens)
            {
                Console.WriteLine(student);
            }
            string[] students2 = { "Esra", "Arslan" };
            foreach (var students in students2)
            {
                Console.WriteLine(students);
            }
        }
    }
}
