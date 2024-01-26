using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            for (int i = 0; i < 10; i++)
            {
                students[i] = new Student("Student" + i, i+10);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(students[i].Name + " " + students[i].Grade);
            }
        }
    }
}
