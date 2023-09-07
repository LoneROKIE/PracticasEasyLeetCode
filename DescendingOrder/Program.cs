using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Your task is to make a function that can take any non-negative
 * integer as an argument and return it with its digits in descending order.
 * Essentially, rearrange the digits to create the highest possible number.
 * 
 *  Examples:
 *   Input: 42145 Output: 54421
 *
 *   Input: 145263 Output: 654321
 *
 *   Input: 123456789 Output: 987654321
 */

public class DescendingOrder
{
    // main method
    public static void Main(String[] args)
    {
        Console.WriteLine("hola");
        DescOrder(5295829);
    }

    public static int DescOrder(int num)
    {
        if (num < 0)
        {
            return 0;
        }

        string temporalNum = num.ToString();

        // convertir la cadena en un array de caracteres
        char[] charArray = temporalNum.ToCharArray();
        // ordenar el array de caracteres en orden desc
        Array.Sort(charArray);
        Array.Reverse(charArray);

        // convertir el array de caracteres de nuevo en una cadena
        string resultStr = new string(charArray);

        // convertir la cadena en un numero entero
        int result = int.Parse(resultStr);

        Console.WriteLine(result);


        return 0;
    }


}

