using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int count = 0;
            foreach (char c in str) 
            {
                if (c == letter)
                {
                    count++;
                }
                else
                {

                }
                    
            }
            return count;
        }
    }
}
