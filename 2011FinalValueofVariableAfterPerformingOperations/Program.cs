using System;

public class Principal
{
    public static void Main(string[] args)
    {
        Console.WriteLine(FinalValueAfterOperations(new string[] { "++X", "X++", "++X" }));
        

    }

    public static int  FinalValueAfterOperations(string[] operations)
    {

        int x = 0;
        string valor = "";
        for(int i=0; i<operations.Length; i++) 
        {
            valor = operations[i];
        switch (valor)
        {
            case "++X":
                ++x;
                break;
            case "X++":
                 x++; 
                break;
            case "--X":
                --x;
                break;
            case "X--":
                 x--;
                break;
            default:
                return 0;
                break;
        }
           
        }
        return x;
    }


}