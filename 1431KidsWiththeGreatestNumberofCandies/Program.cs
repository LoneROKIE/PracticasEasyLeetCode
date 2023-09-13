public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {

        // sacamos el valor mayor de candies
        int mayor = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            if (mayor < candies[i])
            {
                mayor = candies[i];
            }
        }
        // creamos un array de bool
        bool[] resultado = new bool[candies.Length];
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= mayor)
            {
                resultado[i] = true;
            }
            else
            {
                resultado[i] = false;
            }
        }

        return resultado;
    }
}