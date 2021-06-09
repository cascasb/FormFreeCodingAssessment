using System;
using System.IO;

namespace FreeFormAssessment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path;

            Console.WriteLine("This program is designed to take in .txt files that have one integer per line.");
            Console.WriteLine("There are three text files included in this project that act as examples.");
            Console.WriteLine("The names of these text files are TextFile1, TextFile2, and TextFile3.");
            Console.WriteLine("Would you like to access a text file from within this project? (Y/N)");

            bool accessFileFromProject = CheckYesNoInput(Convert.ToChar(Console.ReadLine()));

            if (accessFileFromProject)
            {
                Console.WriteLine("Please enter in the file's name in \"fileName.txt\" format.");
                path = Path.Combine(Environment.CurrentDirectory, Console.ReadLine());
                bool doesFileExist = CheckIfFileExists(path);
                while (!doesFileExist)
                {
                    Console.WriteLine("There is no file with the path " + path);
                    Console.WriteLine("Please enter in a valid file's name in \"fileName.txt\" format.");
                    path = Path.Combine(Environment.CurrentDirectory, Console.ReadLine());
                    doesFileExist = CheckIfFileExists(path);
                }
                Console.WriteLine("the file path " + path + " is valid");
            }
            else
            {
                Console.WriteLine("Please enter the full path for the text file you want to access.");
                path = @"" + Console.ReadLine();
                bool doesFileExist = CheckIfFileExists(path);
                while (!doesFileExist)
                {
                    Console.WriteLine("There is no file with the path " + path);
                    Console.WriteLine("Please enter in a valid file path");
                    path = Path.Combine(Environment.CurrentDirectory, Console.ReadLine());
                    doesFileExist = CheckIfFileExists(path);
                }
                Console.WriteLine("the file path " + path + " is valid");
            }

            string[] numbers = System.IO.File.ReadAllLines(path);
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(FindPrimeFactorization(Convert.ToInt32(numbers[x])));
                
            }
        }
        public static bool CheckYesNoInput(char answer)
        {
            //This method checks to see if the user input a valid answer when prompted to test another triangle
            //valid input includes 'Y', 'y', 'N', and 'n'
            //if a valid character is not input then this method will prompt the user until it is valid

            if (answer == 'Y' || answer == 'y')
            {
                return true;
            }
            else if (answer == 'N' || answer == 'n')
            {
                return false;
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

        public static bool CheckIfFileExists(string path)
        {
            //This method checks to see if the given file path actually leads to a file
            //If it does then it returns true
            //otherwise it returns false
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string FindPrimeFactorization(int num)
        {
            //This method finds the prime factorization of a given number
            //the list of numbers comprising the prime factorization is then returned as a string
            string output = "";
            int primeNum;
            while (!checkForPrimeNumber(num))
            {
                primeNum = 2;

                while(num % primeNum != 0)
                {
                    primeNum = FindNextPrimeNumber(primeNum);
                }

                output += primeNum + ", ";
                num = num / primeNum;
            }
            output += num;

            return output;
        }

        public static int FindNextPrimeNumber(int currentNum)
        {
            //This method finds the next prime number after a given number
            //and returns it as an int
            currentNum++;
            while (!checkForPrimeNumber(currentNum))
            {
                currentNum++;
            }
            return currentNum;
        }

        public static bool checkForPrimeNumber(int num)
        {
            //This method checks to see if a number is prime
            //if the number is prime it returns true
            //otherwise it returns false
            if(num == 0)
            {
                return false;
            }
            else if (num == 1)
            {
                return true;
            }
            else
            {
                for (int x = 2; x < num; x++)
                {
                    if (num % x == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
