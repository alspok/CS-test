using System;

namespace testApp
{
    class  RepeatCharCount
    {
// the odd one
        public void charCount(string testString)
        {
        Console.WriteLine("in charCnt: " + testString);

        string tempChar;
        for(int i = 0; i < testString.Length; i++){
            tempChar = testString.Remove(1);
            Console.WriteLine(tempChar + " removed from " + testString + "\n");
            testString = testString.Substring(1);
            // here the calc...
            }
        }

// the better one
        public int charArrayCount(string testString)
        {
            char[] testStringArray = testString.ToCharArray();

            int count = 1;
            int maxCount = 1;

// aaaaaaaaaaaaaaaaaaaa = 20

            for(int i = 0; i < testStringArray.Length - 1; i++){
                if(testStringArray[i] == testStringArray[i+1]){
                    count++;
                }
                else{
                    count = 1;
                }
                
                if(count > maxCount){
                    maxCount = count;
                }
            }
            return maxCount;
        }
    }
}