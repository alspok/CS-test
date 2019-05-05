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
            // chrCnt.charCount(testString);
            chrCnt.charCount(testString);

            Console.WriteLine(testString);
            maxLength = chrCnt.charArrayCount(testString);
            Console.WriteLine("Max repeated char length " + maxLength);

            foreach(string testStr in testStringArray){
                int maxiLength = chrCnt.charArrayCount(testStr);
                Console.WriteLine(testStr);
                Console.WriteLine("Max repeated char length in string array " + maxLength);
            }

            List<Tuple<string, int>> maxStringArray = chrCnt.stringArrayCount(testStringArray);
        }
    }
}