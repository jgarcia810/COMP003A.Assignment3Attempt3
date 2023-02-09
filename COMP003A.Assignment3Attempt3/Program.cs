// Author: Jaime Garcia
// Course: COMP003A
// Purpose: if-else-switch Assignment 3


namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Letter Grade Section
            Console.WriteLine("Numeric to letter grade using an if-else statement");
            Console.WriteLine("\tEnter a numeric grade (0-100):");
            double numericGrade = Convert.ToDouble(Console.ReadLine()); //stores input

            //Console Output Section
            if (numericGrade >= 0 && numericGrade <= 100)
            {
                if (numericGrade >= 90)
                {
                    Console.WriteLine("\tLetter Grade: A");
                }
                else if (numericGrade >= 80)
                {
                    Console.WriteLine("\tLetter Grade: B");
                }
                else if (numericGrade >= 70)
                {
                    Console.WriteLine("\tLetter Grade: C");
                }
                else if (numericGrade >= 60)
                {
                    Console.WriteLine("\tLetter Grade: D");
                }
                else
                {
                    Console.WriteLine("\tLetter Grade: F");
                }

            }
            else
            {
                Console.WriteLine("Entry error!");
            }



            /////////////////////////////// Integer Using a Switch Statement 
            Console.WriteLine("");
            Console.WriteLine("***************************");
            Console.WriteLine("Integer to string day using a switch statement");
            Console.WriteLine("\tEnter an integer day of the week (1-7):");
            int numericDay = Convert.ToInt32(Console.ReadLine());

            //Console output for Monday string
            switch (numericDay)
            {
                case 1:
                    //MOnday
                    Console.WriteLine("\tString day: Monday");
                    break;
                case 2:
                    //Tuesday executes if true
                    Console.WriteLine("\tString day: Tuesday");
                    break;
                case 3:
                    //Wednesday executes if true
                    Console.WriteLine("\tString day: Wednesday");
                    break;
                case 4:
                    //Thursday executes if true
                    Console.WriteLine("\tString day: Thursday");
                    break;
                case 5:
                    //Friday executes if true
                    Console.WriteLine("\tString day: Friday");
                    break;
                case 6:
                    //Saturday executes if true
                    Console.WriteLine("\tString day: Saturday");
                    break;
                case 7:
                    //Sunday executes if true
                    Console.WriteLine("\tString day: Monday");
                    break;
                default:
                    //executes if none above are true
                    Console.WriteLine("\tInvalid day!");
                    break;


            }








        }








    }
}