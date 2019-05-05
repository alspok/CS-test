using System;
using System.Collections.Generic;

namespace testApp
{
    class  RepeatCharCount
    {
        /* calculates repeated string using Substring() */
        public void charCount(string testString)
        {
        Console.WriteLine("in charCnt: " + testString);

        string tempChar;
        int strLength = testString.Length; 
        for(int i = 0; i < strLength; i++){
            tempChar = testString.Remove(1);
            Console.WriteLine(i + " "  + tempChar + " removed from " + testString + "\n");
            testString = testString.Substring(1);
            // here the calc...
            }
        }

        /* calcutates repeated string using ToCharArray() */
        public int charArrayCount(string testString)
        {
            char[] testCharArray = testString.ToCharArray();

            int count = 1;
            int maxCount = 1;

            for(int i = 0; i < testCharArray.Length - 1; i++){
                if(testCharArray[i] == testCharArray[i+1]){
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
        /* makes List */
        public List<Tuple<string, int>> stringArrayCount(string[] testStringArray)
        {
            List<Tuple<string, int>> stringList = new List<Tuple<string, int>>();

            foreach(string testString in testStringArray){
                int count = this.charArrayCount(testString);
            }
            return stringList;
        }
    }
}