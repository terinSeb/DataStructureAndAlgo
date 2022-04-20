using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAlgos.ArraysAndStrings
{
    public class Program1
    {
        // Method 1
        public Boolean isUniqueChars(string str)
        {            
            Boolean[] char_sert = new Boolean[128];
            for(int i = 0; i< str.Length; i++)
            {
                int val = str.ElementAt(i);
                if (char_sert[val])
                {
                    return false;
                }
                char_sert[val] = true;
            }
            return true;
        }

        // Method 2
        public Boolean isUniqueCharsMthd2(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str.ElementAt(i) - 'a'; // 'a' -- This i.e ''(or Single quotes) will convert 'a' into ASCII code that is 97.
                // The Left Shift Operator (<<) Shifts its first operand left by the number of bits specified by its Second Operand                
                
                // In && the 2nd condtion is not checked if the first condition is false
                // but in case of & Operator the 2nd condition is checked irrespective of the first condition is true or false;
                
                if ( (checker & (1 << val)) > 0) 
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }
    }
}
