using System;

namespace testApp
{
    class Program
    {
        static void Main()
        {
            string testString = "acagtgacacagtgacgggggaaaaaaaaaaaaaaaaaaaattagacccc";
            Console.WriteLine(testString);

            RepeatCharCount chrCnt = new RepeatCharCount();
            // chrCnt.charCount(testString);

            int maxLength = chrCnt.charArrayCount(testString);
            Console.WriteLine("Max repeated char length " + maxLength);
        }
    }
}