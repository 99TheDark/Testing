using System;

class Challenge3 
{
    
    static void Main(string[] args) 
    {
        Console.WriteLine(Convert(5));
        Console.WriteLine(Convert(3));
        Console.WriteLine(Convert(2));
    }
    
    static int Convert(int minutes) 
    {
        return minutes * 60;
    }
    
}
