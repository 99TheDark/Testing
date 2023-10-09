using System;

class Challenge6
{
    
    static void Main(string[] args) 
    {
        /*
        7, 5 => [7, 14, 21, 28, 35]
        12, 10 => [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
        17, 6 => [17, 34, 51, 68, 85, 102]
        */
        PrintArray(ArrayOfMultiples(7, 5));
        PrintArray(ArrayOfMultiples(12, 10));
        PrintArray(ArrayOfMultiples(17, 6));
    }
    
    static int[] ArrayOfMultiples(int num, int length) 
    {
        int[] mults = new int[length];
        
        for(int i = 0; i < length; i++) {
            mults[i] = num * (i + 1);
        }
        
        return mults;
    }
    
    static void PrintArray(int[] arr) 
    {
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }
    
}
