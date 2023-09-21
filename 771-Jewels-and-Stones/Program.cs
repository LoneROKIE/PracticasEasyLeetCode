/*
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:

Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
Example 2:

Input: jewels = "z", stones = "ZZ"
Output: 0 
 */

using System.Text.RegularExpressions;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb"));
    }

    public static int NumJewelsInStones(string jewels, string stones)
    {

        // Construir una expresión regular que represente todas las joyas en "jewels"
        string pattern = "[" + Regex.Escape(jewels) + "]";

        int numeroOcurrencias = Regex.Matches(stones, pattern).Count();
        return numeroOcurrencias;
    }



}