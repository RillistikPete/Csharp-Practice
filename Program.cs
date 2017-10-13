using System;
using System.Collections.Generic;

namespace InterviewQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that accepts a List of Strings 'StrList' and an integer 'testInt' as arguments.
            //Only for strings with a length less than 'testInt', print the list
            //of strings as one continuous string with a space as separator.

            List<string> StringList = new List<string>();
            Survey(StringList, 8);
          
            void Survey(List<string> StrgList, int testInt)
            {
                testInt = 8;
                string[] StrList = {"Hello", "Goodbye", "MoreThanEight"};

                foreach (var j in StrList)
                {
                    if(j.Length < testInt)
                    {
                        Console.WriteLine(string.Join(" ", j));
                    }
                }
                
            }

            //Print each digit of a large number as a list:

            var myNumber= 12345;
            string numberToString = myNumber.ToString();
            var charArray = numberToString.ToCharArray();
            for ( var g = 0; g < charArray.Length; g++)
            {
                Console.WriteLine(charArray[g]);
            } 
        }
    }
}

