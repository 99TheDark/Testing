using System;

class Challenge7
{
    
    static void Main(string[] args) 
    {
        Console.WriteLine(Cons(new int[] { 5, 1, 4, 3, 2 }));
        Console.WriteLine(Cons(new int[] { 5, 1, 4, 3, 2, 8 }));
        Console.WriteLine(Cons(new int[] { 5, 6, 7, 8, 9, 9 }));
        Console.WriteLine(Cons(new int[] { 5, 6, 7, 8, 9, 10 }));
    }
    
    static bool Cons(int[] arr)
    {
        Array.Sort(arr);
        
        int last = arr[0] - 1;
        foreach(int num in arr)
        {
            if(last + 1 != num) return false;
            
            last = num;
        }
        
        return true;
    }
    
}
