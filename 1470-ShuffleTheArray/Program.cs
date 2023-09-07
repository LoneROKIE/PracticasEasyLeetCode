using System;

public class Solution
{
    public static void Main(string[] args)
    {
        Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);

    }

    // solucion
    public static void Shuffle(int[] nums, int n)
    {
        // imprimir el original
        Console.WriteLine("Arreglo original");
        for(int i=0; i<nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        
        int[] ans = new int[n * 2]; // esto es para que el arreglo tenga el doble de tamaño del original
        
        for(int i=0; i<n; i++)
        {
            ans[i * 2] = nums[i];    
            ans[i * 2 + 1] = nums[i + n];
        }


        // imprimir
        Console.WriteLine("Arreglo shuffle");
        for(int i=0; i<ans.Length; i++)
        {
            Console.Write(ans[i] + " ");
        }

    }

}