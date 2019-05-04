using System;

namespace testApp
{
    class Program
    {
        static void Main()
        {
            string testString = "acagtgacacagtgacgggggaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaattagacccc";
            Console.WriteLine(testString);

            

            RepeatCharCount chrCnt = new RepeatCharCount();
            // chrCnt.charCount(testString);

            int maxLength = chrCnt.charArrayCount(testString);
            Console.WriteLine("Max repeated char length " + maxLength);

            string[] testStringArray = new string[]{
                "aaaaaaaaaggggggggggg",
                "agagagagggggggggggggggggggg",
                "tttatatagacatt",
                "gagaggggggagagcccacaccc"
            };

            foreach(string testStr in testStringArray){
                maxLength = chrCnt.charArrayCount(testStr);
                Console.WriteLine(testStr);
                Console.WriteLine("Max repeated char length in string array " + maxLength);
            }
        }
    }
}