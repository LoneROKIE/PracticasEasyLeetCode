/*
    You are given an m x n integer grid accounts where accounts[i][j] is the amount of money 
    the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
    A customer's wealth is the amount of money they have in all their bank accounts.
    The richest customer is the customer that has the maximum wealth.
 */

public class Solution
{
    public static void Main(string[] args)
    {
        MaximumWealth(new int[][] {new int[] {1,2,3}, new int[] {3,2,1} });
    }

    public static void MaximumWealth(int[][] accounts)
    {
       int[] arreglo = new int[accounts.Length];
        for (int i=0; i < accounts.Length; i++)
        {
           
            for(int j=0; j < accounts[i].Length; j++)
            {
                Console.Write(accounts[i][j]+" ");
                arreglo[i] += accounts[i][j];
            }
            Console.WriteLine(" ");
        }
        int aux = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if(aux <= arreglo[i])
            {
                aux = arreglo[i];
            }
            Console.WriteLine(arreglo[i]);
        }
        Console.WriteLine("MAYOR MILLONARIO: "+aux);

    }
}