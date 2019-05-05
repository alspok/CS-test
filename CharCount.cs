using System;
using System.Collections.Generic;

namespace testApp
{
    class  RepeatCharCount
    {
        /* calculates repeated chaar string using Substring() */
        public int charCount(string testString)
        {
            // Console.WriteLine("in charCnt testString: " + testString);

            int strLength = testString.Length; 
            int count = 1;
            int maxCount = 1;

            for(int i = 0; i < strLength - 1; i++){
                string subString1 = testString.Substring(0, 1);
                string subString2 = testString.Substring(1, 1);
                
                if(subString1 == subString2){
                    count++;
                }
                else{
                    count = 1;
                }

                if(count > maxCount){
                    maxCount = count;
                }

            testString = testString.Remove(0, 1);
            // Console.WriteLine(i + " "  + testString + " removed from " + testString + "\n");
            }

            return maxCount;
        }

        /* calcutates repeated char string using ToCharArray() */
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

        /* makes List of repeaded strings in string array*/
        public List<Tuple<string, int>> stringArrayCount(string[] testStringArray)
        {
            List<Tuple<string, int>> repeatedList = new List<Tuple<string, int>>();
            string repeatChar;

            foreach(var testString in testStringArray){
                int count = this.charArrayCount(testString);
                repeatChar = testString.Substring(0, 1);
                repeatedList.Add(Tuple.Create(repeatChar, count));
            }

            return repeatedList;
        }
    }
}