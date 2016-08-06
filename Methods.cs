using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercises
{
    //class for misc. methods
    public static class Methods
    {
        //find the average of an array
        public static double average(ref double[] array)
        {
            //variable for holding sum of values in array
            double sum = 0;

            //loop through array and add values to sum variable
            foreach (double thing in array)
                sum += thing;

            //calculate average and store it in avg, return the average
            double avg = (sum / array.Length);
            return avg;
        }

        //makes a pyramid of some symbol of the desired height, looks best with single characters
        public static void pyramid(int height)
        {
            //declare symbols to be used, can change 'symbol' parameter if desired 
            string symbol = "*";
            string symbolCopy = symbol;
            //print nothing if the height isn't > 0
            if (height <= 0)
                Console.WriteLine();
            else
                //the first loop controls the height
                for (int x = 0; x < height; ++x)
                {
                    //these next two loops control how many times the space and symbol are printed
                    for (int y = height - x - 1; y >= 0; --y)
                        Console.Write(" ");
                    for (int z = x; z <= x; ++z)
                    {
                        Console.Write(symbol);
                        symbol += (" " + symbolCopy);
                    }
                    //go to next level of pyramid
                    Console.WriteLine();
                }
        }

        //sum up the sequence x + xx + xxx... for as many values as 'size'
        public static void specialSum(int num, int size)
        {
            //need the size of the sequence to be at least 1
            if (size <= 0)
                Console.WriteLine("Size too small");
            else
            {
                //make variables to hold the initial value, a copy, and the sum of the sequence
                int initial = num;
                int initialCopy = initial;
                int sum = 0;
                //loop to calculate sequence values and add them to the total sum
                for (int x = 1; x <= size; ++x)
                {
                    sum += initial;
                    if (x == size)
                        Console.Write(initial + " = ");
                    else
                        Console.Write(initial + " + ");
                    initial = ((initial * 10) + initialCopy);
                }
                //print the series finally and break to a new line
                Console.Write(sum);
                Console.WriteLine();
            }
        }

        //counts the words in a string
        public static int wordCount(string str)
        {
            //variable keeping word count
            int wordCount = 1;

            //loop through string, starting at second value to compare to first value
            //only count spaces, ignore multiple spaces in a row
            for (int x = 0; x < str.Length; ++x)
            {
                if ((x > 0) && (str[x] == ' ') && (str[x] != str[x - 1]))
                    ++wordCount;
            }

            return wordCount;
        }

        //compare two strings and see if they are the same
        public static void stringCompare(string s1, string s2)
        {
            //variable for counting if string characters are the same in a following loop
            int stringCompare = 0;

            //if the lengths are not equal the strings are not equal
            if (s1.Length != s2.Length)
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", s1, s2);

            else if (s1.Length == s2.Length)
            {
                //compare characters of each string at each index to check for equality
                for (int x = 0; x < s1.Length; ++x)
                {
                    if (s1[x] == s2[x])
                        ++stringCompare;
                }

                //if all characters were equal, and the string lengths are equal, the strings are equal
                if (stringCompare == s1.Length)
                    Console.WriteLine("\"{0}\" and \"{1}\" are equal", s1, s2);
                else
                    Console.WriteLine("\"{0}\" and \"{1}\" are not equal", s1, s2);
            }

            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", s1, s2);
        }

        //method to find the most frequent characters in a string
        public static void mostCommonChar(string s)
        {
            //dictionary for holding characters and their frequency in the string
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            //loops through string and puts characters + the number of times they appear into charCount dictionary
            //use ToLower() to account for different capitalizations
            foreach (char value in s.ToLower())
            {
                if (value == ' ') //ignore spaces!
                    continue;
                else if (charCount.Keys.Contains(value)) //update value count if character is in dictionary
                    ++charCount[value];
                else
                    charCount[value] = 1; //add character to dictionary if it isn't in there
            }

            //loop through dictionary and a value with the highest number, and thus highest frequency
            int mostFrequentCharCount = 0;
            foreach (char key in charCount.Keys)
            {
                if (charCount[key] > mostFrequentCharCount)
                {
                    mostFrequentCharCount = charCount[key];
                }
            }

            //there may be multiple characters that appear the most
            //so loop through the dictionary again to print all characters with the highest frequency
            Console.WriteLine("Most common character(s):");
            foreach (char key in charCount.Keys)
            {
                if (charCount[key] == mostFrequentCharCount)
                    Console.WriteLine(key + " : " + charCount[key] + " times");
            }
        }

        //fibonacci sequence calculator for first n values
        public static void fib(int n)
        {

            if (n <= 0)
                Console.WriteLine("Invalid entry");
            else if (n == 1)
                Console.WriteLine("1");
            else if (n == 2)
                Console.WriteLine("1 1");
            //after the first two sequence values, make a list to hold the sequence
            //calculate the newest entry based on the previous two, up to the desired size
            else
            {
                List<int> fibs = new List<int>();
                fibs.Add(1);
                fibs.Add(1);
                for (int x = 1; x <= n-2; ++x)
                {
                    fibs.Add(fibs[x] + fibs[x - 1]);
                }

                foreach (int value in fibs)
                    Console.Write(value + " ");
                Console.WriteLine();
            }
        }

        //method to get sum of individual numbers in a string
        public static int sumOfNumbers(string longString)
        {
            int sum = 0;
            foreach (char value in longString)
            {
                switch (value)
                {
                    case ('0'):
                        sum += 0;
                        break;
                    case ('1'):
                        sum += 1;
                        break;
                    case ('2'):
                        sum += 2;
                        break;
                    case ('3'):
                        sum += 3;
                        break;
                    case ('4'):
                        sum += 4;
                        break;
                    case ('5'):
                        sum += 5;
                        break;
                    case ('6'):
                        sum += 6;
                        break;
                    case ('7'):
                        sum += 7;
                        break;
                    case ('8'):
                        sum += 8;
                        break;
                    case ('9'):
                        sum += 9;
                        break;
                    default:
                        break;
                }
            }
            return sum;
        }

        //method to get sum of individual numbers in a longer number
        public static int sumOfNumbers(int longNumber)
        {
            int sum = 0;
            foreach (char value in longNumber.ToString())
            {
                switch (value)
                {
                    case ('0'):
                        sum += 0;
                        break;
                    case ('1'):
                        sum += 1;
                        break;
                    case ('2'):
                        sum += 2;
                        break;
                    case ('3'):
                        sum += 3;
                        break;
                    case ('4'):
                        sum += 4;
                        break;
                    case ('5'):
                        sum += 5;
                        break;
                    case ('6'):
                        sum += 6;
                        break;
                    case ('7'):
                        sum += 7;
                        break;
                    case ('8'):
                        sum += 8;
                        break;
                    case ('9'):
                        sum += 9;
                        break;
                    default:
                        break;
                }
            }
            return sum;
        }

        //factorial calculator, n!
        //only valid for n >= 0
        public static int factorial(int n)
        {
            int fac = 1;
            for (int x = 2; x <= n; ++x)
                fac *= x;
            return fac;
        }

        //method for doing a binary search on an integer array
        public static void binarySearch(int[] a, int target)
        {
            //set variables for Left and Right ends of array
            int L = 0;
            int R = a.Length - 1;
            bool run = true;
            while (run)
            {
                //set variable for Midpoint of array
                int M = ((L + R) / 2);
                if (L > R)
                {
                    //array is empty, search failed
                    Console.WriteLine("Search failed");
                    run = false;
                }
                else if (a[M] < target)
                {
                    //midpoint is less than target, cut off lower end of array
                    L = M + 1;
                }
                else if (a[M] > target)
                {
                    //midpoint is greater than target, cut off top half of array
                    R = M - 1;
                }
                else if (a[M] == target)
                {
                    //target found, return its index
                    Console.WriteLine("Index: " + Array.IndexOf(a, a[M]));
                    run = false;
                }
            }
        }

        //method for doing a bubble sort on an int array, and returning the sorted array
        public static int[] bubbleSort(int[] array)
        {
            //maximum number of sorts needed to sory whole array is the length of the array
            //for each run, compare adjacent values. If the one in front is bigger, swap them
            for (int x = 1; x != array.Length; ++x)
            {
                for (int y = 1; y != array.Length; ++y)
                {
                    if (array[y - 1] > array[y])
                    {
                        int a = array[y - 1];
                        int b = array[y];
                        array[y - 1] = b;
                        array[y] = a;
                    }
                    else
                        continue;
                }
            }
            return array;
        }
    }
}
