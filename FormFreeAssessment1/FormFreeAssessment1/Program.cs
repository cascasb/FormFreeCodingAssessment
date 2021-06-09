using System;

namespace FormFreeAssessment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double side1, side2, side3;
            bool testAnotherTriangle = true;
            string currentInput = "";

            Console.WriteLine("This program takes in three measurements that represent sides of a triangle. " +
                "\nThe program then outputs is the trianlge is scalene, isosceles, or equilateral.\n");

            while(testAnotherTriangle)
            {
                Console.WriteLine("Please input the length of side one of your triangle:");
                currentInput = Console.ReadLine();
                if (CheckValidInput(currentInput))
                {
                    side1 = Convert.ToDouble(currentInput);
                }
                else
                {
                    bool isValidInput = false;
                    while (!isValidInput)
                    {
                        Console.WriteLine("Please input a valid number for the lenght of side one of your triangle:");
                        currentInput = Console.ReadLine();
                        if (CheckValidInput(currentInput))
                        {
                            isValidInput = true;
                        }
                    }
                    side1 = Convert.ToDouble(currentInput);

                }
                Console.WriteLine("Please input the length of side two of your triangle:");
                currentInput = Console.ReadLine();
                if (CheckValidInput(currentInput))
                {
                    side2 = Convert.ToDouble(currentInput);
                }
                else
                {
                    bool isValidInput = false;
                    while (!isValidInput)
                    {
                        Console.WriteLine("Please input a valid number for the lenght of side two of your triangle:");
                        currentInput = Console.ReadLine();
                        if (CheckValidInput(currentInput))
                        {
                            isValidInput = true;
                        }
                    }
                    side2 = Convert.ToDouble(currentInput);
                }
                Console.WriteLine("Please input the length of side three of your triangle");
                currentInput = Console.ReadLine();
                if (CheckValidInput(currentInput))
                {
                    side3 = Convert.ToDouble(currentInput);
                }
                else
                {
                    bool isValidInput = false;
                    while (!isValidInput)
                    {
                        Console.WriteLine("Please input a valid number for the lenght of side three of your triangle:");
                        currentInput = Console.ReadLine();
                        if (CheckValidInput(currentInput))
                        {
                            isValidInput = true;
                        }
                    }
                    side3 = Convert.ToDouble(currentInput);
                }

                if (!CheckTriangleValidity(side1, side2, side3))
                {
                    Console.WriteLine("The sides given do not make a valid trianlge");
                    Console.WriteLine("Would you like to test another triangle? (Y/N)");
                    testAnotherTriangle = CheckContinueInput(Convert.ToChar(Console.ReadLine()));
                }
                else if (CheckForEquilateral(side1, side2, side3))
                {
                    Console.WriteLine("The sides given make an equilateral triangle");
                    Console.WriteLine("Would you like to test another triangle? (Y/N)");
                    testAnotherTriangle = CheckContinueInput(Convert.ToChar(Console.ReadLine()));
                }
                else if (CheckForIsosceles(side1, side2, side3))
                {
                    Console.WriteLine("The sides given make an isosceles triangle");
                    Console.WriteLine("Would you like to test another triangle? (Y/N)");
                    testAnotherTriangle = CheckContinueInput(Convert.ToChar(Console.ReadLine()));
                }
                else if (CheckForScalene(side1, side2, side3))
                {
                    Console.WriteLine("The sides given make a scalene triangle");
                    Console.WriteLine("Would you like to test another triangle? (Y/N)");
                    testAnotherTriangle = CheckContinueInput(Convert.ToChar(Console.ReadLine()));
                }
            }
        }

        public static bool CheckTriangleValidity(double side1, double side2, double side3)
        {
            //This method checks to see if a the given measurements make a valid triangle
            //a trianlge is not valid if the sum of two sides is less than or equal to the thrid side
            //a trianlge also cannot have a side of zero or negative length

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return false;
            }
            if (side1 + side2 <= side3)
            {
                return false;
            }
            else if (side2 + side3 <= side1)
            {
                return false;
            }
            else if (side3 + side1 <= side2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckForEquilateral(double side1, double side2, double side3)
        {
            //This method checks to see if a see if the given measurements make an equilateral triangle
            //a triangle is only equailateral if all 3 sides are the same length

            if (side1 == side2 && side1 == side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckForIsosceles(double side1, double side2, double side3)
        {
            //This method checks to see if a see if the given measurements make an isosceles triangle
            //a trianlge is isosceles only if two of the three sides are the same length

            if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckForScalene(double side1, double side2, double side3)
        {
            //This method checks to see if a see if the given measurements make a scalene triangle
            //a triangle is only scalene is all the sides are differnt lengths

            if (side1 != side2 && side2 != side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckContinueInput(char answer)
        {
            //This method checks to see if the user input a valid answer when prompted to test another triangle
            //valid input includes 'Y', 'y', 'N', and 'n'
            //if a valid character is not input then this method will prompt the user until it is valid

            if (answer == 'Y' || answer == 'y')
            {
                return  true;
            }
            else if (answer == 'N' || answer == 'n')
            {
                return  false;
            }
            else
            {
                bool answerValid = false;
                while (!answerValid)
                {
                    Console.WriteLine("Please input a valid response. Would you like to test another triangle? (Y/N)");
                    answer = Convert.ToChar(Console.ReadLine());
                    if (answer == 'Y' || answer == 'y' || answer == 'N' || answer == 'n')
                    {
                        answerValid = true;
                    }
                }
                if (answer == 'Y' || answer == 'y')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool CheckValidInput(string input)
        {
            //this method checks to see if the input for the side lenghts can be converted into doubles

            if (double.TryParse(input, out double output))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
