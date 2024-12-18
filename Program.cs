﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using System.Linq;
using System.Reflection.PortableExecutable;

public class Solution
{
    public int LengthOfLastWord(string s)
    {

        string sTrim = s.Trim();
        if (sTrim == "") return 0;

        char characterToFind = ' ';
        int lastSpace = sTrim.LastIndexOf(characterToFind);
        string lastWord = sTrim.Substring(lastSpace + 1);
        int lastWordLength = lastWord.Length;


        return lastWordLength;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        string s1 = "Hello World";
        Console.WriteLine(s.LengthOfLastWord(s1));

        string s2 = "   fly me   to   the moon  ";
        Console.WriteLine(s.LengthOfLastWord(s2));

        string s3 = "luffy is still joyboy";
        Console.WriteLine(s.LengthOfLastWord(s3));

        string s4 = "       ";
        Console.WriteLine(s.LengthOfLastWord(s4));


    }


}
