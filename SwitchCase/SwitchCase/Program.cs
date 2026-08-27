using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //With If else
            int x = int.Parse(Console.ReadLine());
            string day;
            if (x == 1)
            {
                day = "Sunday";
            }
            else if (x == 2)
            {
                day = "Monday";
            }
            else if (x == 3)
            {
                day = "Tuesday";
            }
            else if (x == 4)
            {
                day = "Wednesday";
            }
            else if (x == 5)
            {
                day = "Thursday";
            }
            else if (x == 6)
            {
                day = "Friday";
            }
            else if (x == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }
            Console.WriteLine("Day: " + day);

            //------------------

            //With Switch-Case
            int x2 = int.Parse(Console.ReadLine());
            string day2;
            switch (x2)
            {
                case 1:
                    day2 = "Sunday";
                    break;
                case 2:
                    day2 = "Monday";
                    break;
                case 3:
                    day2 = "Tuesday";
                    break;
                case 4:
                    day2 = "Wednesday";
                    break;
                case 5:
                    day2 = "Thursday";
                    break;
                case 6:
                    day2 = "Friday";
                    break;
                case 7:
                    day2 = "Saturday";
                    break;
                default:
                    day2 = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day2);
        }
    }
}