using System;

namespace testApp
{
    class  RepeatCharCount
    {
// odd 2ay
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

// the better way
        public int charArrayCount(string testString)
        {
            Console.WriteLine("in charArrayCount: " + testString);

            char[] testStringArray = testString.ToCharArray();

            int tempCount = 0;
            int maxCount = 0;
            for(int i = 0; i < testStringArray.Length - 1; i++){
                if(testStringArray[i] == testStringArray[i+1]){
                    tempCount++;
                    maxCount = tempCount;
                else{
                    tempCount = 0;
                }
            }
            return maxCount;
        }
    }
}