using System;
using System.Collections.Generic;

namespace InterviewQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

