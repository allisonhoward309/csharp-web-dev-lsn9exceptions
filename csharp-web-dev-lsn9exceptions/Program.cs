using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("Divide by 0 error.");
            }
            else
            {
                return x / y;
            }

        }


        static int CheckFileExtension(string fileName)
        {
            string substg = fileName.Substring(fileName.Length - 3);
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("No file was submitted.");
            }
            else if ( substg == ".cs")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {
            double x = 9.9;
            double y = 0.0;

            try
            {
                Divide(x, y);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Help out the teacher!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key);
                    CheckFileExtension(student.Value);
                }
                catch (ArgumentNullException n)
                {
                    Console.WriteLine(n.Message);
                }
            }
        }
    }
}

    
