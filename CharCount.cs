using System;

namespace testApp
{
    class  RepeatCharCount
    {
        public void charCount(string testString)
        {
        Console.WriteLine("in charCnt: " + testString);

        string tempChar;
        for(int i = 0; i < testString.Length; i++){
            tempChar = testString.Remove(1);
            Console.WriteLine(tempChar + " removed " + testString + "\n");
            testString = testString.Substring(1);
            }
        }
    }
}