using System;

namespace testApp
{
    class Program
    {
        static void Main()
        {
            string testString = "acagtgacacagtgacgggggaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaattagacccc"; // 31
            Console.WriteLine(testString);

            

            RepeatCharCount chrCnt = new RepeatCharCount();
            // chrCnt.charCount(testString);

            int maxLength = chrCnt.charArrayCount(testString);
            Console.WriteLine("Max repeated char length " + maxLength);

            string[] testStringArray = new string[]{
                "aaaaaaaaaggggggggggg", // 11
                "agagagagggggggggggggggggggg", // 20
                "tttatatagacatt", // 3
                "gagaggggggagagcccacaccc", //6
                "ttttttttttttttttttttttttttttttaaaaaaaaaaaaaaaaaaaa" //30
            };

            foreach(string testStr in testStringArray){
                maxLength = chrCnt.charArrayCount(testStr);
                Console.WriteLine(testStr);
                Console.WriteLine("Max repeated char length in string array " + maxLength);
            }
        }
    }
}