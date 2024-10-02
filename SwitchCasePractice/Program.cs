using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCasePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer value");
            int num = Convert.ToInt32(Console.ReadLine());
            int gradeCategory;

            if (num >= 1 && num <= 32)
            {
                gradeCategory = 0;
            }
            else if (num >= 33 && num <= 39)
            {
                gradeCategory = 1;
            }
            else if (num >= 40 && num <= 49)
            {
                gradeCategory = 2;
            }
            else if (num >= 50 && num <= 59)
            {
                gradeCategory = 3;
            }
            else if (num >= 60 && num <= 69)
            {
                gradeCategory = 4;
            }
            else if (num >= 70 && num <= 79)
            {
                gradeCategory = 5;
            }

            else if (num >= 80 && num <= 100)
            {
                gradeCategory = 6;
            }
            else
            {
                gradeCategory = -1;
            }

            switch (gradeCategory)
            {
                case 0:
                    Console.WriteLine("This student does not get passing marks");
                    break;

                case 1:
                    Console.WriteLine("This student passing grade is D");
                    break;
                case 2:
                    Console.WriteLine("This student passing grade is C");
                    break;
                case 3:
                    Console.WriteLine("This student passing grade is B");
                    break;
                case 4:
                    Console.WriteLine("This student passing grade is A-");
                    break;
                case 5:
                    Console.WriteLine("This student passing grade is A");
                    break;
                case 6:
                    Console.WriteLine("This student passing grade is A+");
                    break;
                default:
                    Console.WriteLine("This student was not present during the exam thus he failed");
                    break;


            }

            Console.ReadLine();








        }
    }
}
