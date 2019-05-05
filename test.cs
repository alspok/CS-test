using System;
using System.Collections.Generic;

namespace testApp
{
    class Program
    {
        static void Main()
        {
            int maxLength;
            string testString = "acagtgacacagtgacgggggaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaattagacccc"; // 31
            string[] testStringArray = new string[]{
                "aaaaaaaaaggggggggggg", // 11
                "agagagagggggggggggggggggggg", // 20
                "tttatatagacatt", // 3
                "gagaggggggagagcccacaccc", // 6
                "ttttttttttttttttttttttttttttttaaaaaaaaaaaaaaaaaaaa" // 30
            };

            RepeatCharCount chrCnt = new RepeatCharCount();

            /* calcs max repeated char length using Substring */
            maxLength =  chrCnt.charCount(testString);
            Console.WriteLine("Max repeated char length in string " + testString + " is " + maxLength + "\n");

            /* calcs nax repeated char length using ToCharArray */
            maxLength = chrCnt.charArrayCount(testString);
            Console.WriteLine("Max repeated char length in string " + testString + " is " + maxLength + "\n");

            /* gets repeated substrings in strings array */
            foreach(string testStr in testStringArray){
                maxLength = chrCnt.charArrayCount(testStr);
                Console.WriteLine("Max repeated char length in string array of string " + testStr + " is " + maxLength);
            }
            Console.WriteLine("\n");

            /* gets List of most repeated char strings */
            List<Tuple<string, int>> maxStringArray = chrCnt.stringArrayCount(testStringArray);
            foreach(var tuple in maxStringArray){
                Console.WriteLine(tuple.Item1.ToString() + " " + tuple.Item2.ToString());
            }
        }
    }
}