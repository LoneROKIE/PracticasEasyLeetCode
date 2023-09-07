
/*
 * DADO UN ENTERO X, DEVUELVE TRUE SI X ES UN NUMERO PALINDROMO.
 *  
 *  EXAMPLE 1:
 *      INPUT: X = 121
 *      OUTPUT: true
 *      EXPLANATION 121 reads as 121 from left to right and from right to left
 * 
 */

public class NumeroPalindromo
{
    public static void Main(string[] args)
    {
        Espalindromo(340);
        Espalindromo(-121);
    }


    public static void Espalindromo(int numero)
    {
        
        // voy a convertir a string el numero
        string numeroString = numero.ToString();

        // esta linea me da un string como tipo lo que quiere decir que si se puedo convertir
        Console.WriteLine(numeroString.GetType());

        // creamos un array con el tamanio de el string de numero
        string[] arrayNumeroString = new string[numeroString.Length];

        // ahora vamos a mandar el string a el array
        for(int i = 0;  i < arrayNumeroString.Length; i++)
        {
            arrayNumeroString[i] = numeroString[i].ToString();
        }

        // ahora imprimimos el arreglo
        
        Console.WriteLine("Arreglo sin invertir");
        foreach(string num in arrayNumeroString)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Arreglo invertido");
        Array.Reverse(arrayNumeroString);
        foreach (string num in arrayNumeroString)
        {
            Console.WriteLine(num);
        }

        // ahora vamos a convertir el arreglo invertido en un string y luego en un int, para luego comparar con el parametro int
        Console.WriteLine("Empezamos la conversion del arreglo a un string y luego a int");
        var numeroInvertido = "";
        foreach(string num in arrayNumeroString)
        {
            numeroInvertido += string.Join("", num).ToString();
        }

        Console.WriteLine(String.Format("Imprimimos el numero invertido pero aun es string: {0} ", numeroInvertido));

        // listo ahora ese numero lo vamos a convertir a un int para luego compararlo
        int numeroInvInt = int.Parse(numeroInvertido);
        Console.WriteLine(String.Format("Revisamos el tipo de numeroInvInt para asegurarnos que ahora es un int: {0}", numeroInvInt.GetType()));

        // ahora imprimimos el numero
        Console.WriteLine(numeroInvInt);

        // ahora comparamos si el numero  invertido es igual al del parametro
        if(numeroInvInt == numero) 
        {
            Console.WriteLine("El numero es Palindromo");
        }
        else
        {
            Console.WriteLine("El numero no es Palindromo");
        }

    }
}