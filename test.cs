using System;

namespace testApp
{
    class Program
    {
        static void Main()
        {
            string testString = "aacagtgacacagtgacgggggaaaaaaaaaaaattagacccc";
            // Console.WriteLine(testString);

            RepeatCharCount chrCnt = new RepeatCharCount();
            chrCnt.charCount(testString);
            int maxLength = chrCnt.charArrayCount(testString);
            Console.WriteLine(maxLength);
        }
    }
}