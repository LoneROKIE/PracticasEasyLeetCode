public class Solution
{
    public static void Main(string[] args)
    {
        RunningSum(new int[] {1, 2, 3, 4, 5, 6});
        //  result            1, 3, 6, 10, 15, 21
    }

    public static int[] RunningSum(int[] nums)
    {
        int suma = 0;
        // arreglo nuevo
        int[] arregloNuevo = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            
            
                suma += nums[i];
                arregloNuevo[i] = suma;
            
        }

        // imprimimos el nuevo arreglo
        for (int i = 0; i < arregloNuevo.Length; i++)
        {
            Console.WriteLine(arregloNuevo[i]);
        }
        return arregloNuevo;
    }
}