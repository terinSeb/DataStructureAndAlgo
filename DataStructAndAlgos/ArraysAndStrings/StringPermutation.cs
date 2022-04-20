using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAlgos.ArraysAndStrings
{
    public class StringPermutation
    {
        //Method1
       public  string sort(string s)
        {
            char[] content = s.ToCharArray();
            //In C#, ToCharArray() is a string method. This method is used to copy the
            //characters from a specified string in the current instance to a Unicode character array
            //or the characters of a specified substring in the current instance to a Unicode character array.
            Array.Sort(content);
            //The above code will sort the Array
            return new string(content);
        }
        public Boolean permutation (string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            return sort(s).Equals(sort(t));
            //The above code will check weather the sorted array are equal.
        }

        //Method2
        public Boolean permutation2(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] letters = new int[128];
            char[] s_array = s.ToCharArray();
            foreach(Char c in s_array)
            {
                letters[c]++;
            }

            for(int i = 0; i <t.Length; i++)
            {
                int c = (int) t.ElementAt(i);
                letters[c]--;
                if(letters[c] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
