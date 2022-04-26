using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructAndAlgos.ArraysAndStrings
{
    public class Palind_Permutation
    {
        Boolean isPermitationOfPelindrom(string Phrase)
        {
            int[] table = buildCharFrequencyTable(Phrase);
            return checkMaxOneOdd(table);
        }
        //Check that no more that one Charactar has an odd Count.
        Boolean checkMaxOneOdd(int[] table)
        {
            Boolean foundOdd = false;
            foreach(int count in table)
            {
                if(count % 2 == 1)
                {
                    if (foundOdd)
                    {
                        return false;
                    }
                    foundOdd = true;
                }
            }
            return true;
        }
        //Map each character to a numbe , a-> 0, b -> 1, c-> 2 etc.
        // This is case insensitive. Non -letter characters map to -1.
        double getCharNumbers(char c)
        {
            double a = Char.GetNumericValue('a');
            double z = Char.GetNumericValue('z');
            double A = Char.GetNumericValue('A');
            double Z = Char.GetNumericValue('Z');

            double val = Char.GetNumericValue(c);
            if (a <= val && val <= z)
            {
                return val - a;
            }
            else if (A <= val && val <= Z)
            {
                return val - Z;
            }
            return -1;
        }
        int[] buildCharFrequencyTable(string Phrase)
        {
            double v = (Char.GetNumericValue('Z') - Char.GetNumericValue('a'));
            double[] table = new double[v];
            return null;
        }
    }
}
