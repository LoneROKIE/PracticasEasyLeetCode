/*
There are n employees in a company, numbered from 0 to n - 1. 
Each employee i has worked for hours[i] hours in the company.

The company requires each employee to work for at least target hours.

You are given a 0-indexed array of non-negative integers hours of length n and a non-negative 
integer target.

Return the integer denoting the number of employees who worked at least target hours.
 */

public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(NumberOfEmployeesWhoMetTarget(new int[] { 1, 2, 3, 4, 5, }, 2));
    }

    public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        int completado = 0;
        for(int i = 0; i < hours.Length; i++)
        {
            if (hours[i] >= target) completado++;
        }

        return completado;
    }

}