using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAlgos.ArraysAndStrings
{
    public class Palind_Permutation
    {
        //Method 1
        public bool canFormPalindrome(string str)
        {
            str = str.ToLower();
            // Create a count array and initialize all
            // values as 0
            int countOdd = 0;
            int[] count = new int[256];
            Array.Fill(count, 0);

            foreach (char c in str.ToCharArray())
            {
                double x = getCharNumber(c);
                if(x != -1)
                {
                  int  unicodeInt = Convert.ToInt32(x);
                    count[unicodeInt]++;
                    if(count[unicodeInt] % 2 == 1)
                    {
                        countOdd++;
                    }
                    else
                    {
                        countOdd--;
                    }
                }
            }

            return countOdd <= 1;
        }

        double getCharNumber(char c)
        {
            int unicodeInt = (int)c;
           if (((unicodeInt > 65) && (unicodeInt < 90))
                || ((unicodeInt > 97) && (unicodeInt < 122)))
            {
                return unicodeInt;
            }
            else
            {
                return -1;
            }
        }

        //-------------------------------- Method2  -Using Bitwise Operator --------------------------
        int toogle(int bitvector, double index)
        {
            if (index < 0) return bitvector;

            int mask = 1 << Convert.ToInt32(index);
            if((bitvector & mask) == 0)
            {
                bitvector |= mask;
            }
            else
            {
                bitvector &= ~mask;
            }
            return bitvector;
        }

        bool CheckExactlyOneBitSet(int bitVector)
        {
            return (bitVector & (bitVector - 1)) == 0;
        }
        int CreateBitVector(string phrase)
        {
            int bitVector = 0;
            foreach(char c in phrase.ToCharArray())
            {
                double x = getCharNumber(c);
                bitVector = toogle(bitVector, x);
            }
            return bitVector;
        }
       public  bool isPermutationOfPelindrom(string Phrase)
        {
            int bitVector = CreateBitVector(Phrase);
            return bitVector == 0 || CheckExactlyOneBitSet(bitVector);
        }
    }
}
