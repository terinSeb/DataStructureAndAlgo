using DataStructAndAlgos.ArraysAndStrings;
using System;

namespace DataStructAndAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1 Implement an Algorithm to determine if a string has all unique characters. What if you cannot use additional dataStructure.
            Program1 objProg = new Program1();
            // a) Method 1
            //objProg.isUniqueChars("abcdefghid");
            // b) Method 2 -- Using Bit Vector
            //objProg.isUniqueCharsMthd2("abcdefghid");
            //Console.WriteLine("Hello World!");

            //1.2 Given two strings write a method to decide if one is a permutation of the other.
            //A Permutation of a string is another string that contains same characters,
            //only the order of characters can be different. For example, “abcd” and “dabc” are Permutation of each other.
            //a) Method 1
            // StringPermutation obj = new StringPermutation();
            //obj.permutation("abcd", "badc");
            //b) Method 2
            //obj.permutation2("abcd", "badc");

            //1.3 URLify
            Urilify objMeth = new Urilify();
            objMeth.ReplaceSpace("Mr John Smith     ".ToCharArray(), "Mr John Smith     ".Trim().Length);
        }
    }
}
