using System;
using System.Collections.Generic;

namespace InterviewQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that accepts a List of Strings 'StrList' and an integer 'testInt' as arguments.
            //Return all strings with a length less than 'testInt' as one continuous string, with a space as a separator.

            List<string> StringList = new List<string>();
            Survey(StringList, 8);
          
            void Survey(List<string> StrgList, int testInt)
            {
                testInt = 8;
                string[] StrList = {"Hello", "Goodbye", "MoreThanEight"};
                string ns = "Solution: ";
                foreach (var j in StrList)
                {
                    if(j.Length < testInt)
                    {
                        ns+=j;
                    }
                        Console.WriteLine("{0}", ns);
                }
                
            }

            //Print each digit of a large number as a list:

            var myNumber= 12345;
            string numberToString = myNumber.ToString();
            var numberList = "";
            for ( var g = 0; g < numberToString.Length; g++)
            {
                numberList += g;
            } 
            Console.WriteLine(numberList);
        }
    }
}

