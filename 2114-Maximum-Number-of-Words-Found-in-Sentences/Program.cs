using System.Collections.Generic;

public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MostWordsFound(new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }));
    }


    public static int MostWordsFound(string[] sentences)
    {
        int mayor = 0;

        foreach (string sentence in sentences)
        {
            // Dividir la oración en palabras usando espacios en blanco como delimitador
            string[] palabras = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Contar la cantidad de palabras en la oración
            int contadorPalabras = palabras.Length;

            // Actualizar la variable "mayor" si es necesario
            if (contadorPalabras > mayor)
            {
                mayor = contadorPalabras;
            }
        }

        return mayor;
    }

}