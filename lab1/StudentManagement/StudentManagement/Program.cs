using System;
using System.Collections.Generic;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Student derek = new Student("der", "dorj", 20, "CS", 2);
            Student eva = new Student("eva", "bayar", 21, "IR", 5);

            foreach (var id in Student.StudentIDs)
            {
                Console.Write(id + ", ");
            }
            Console.WriteLine();
        }
    }
}
