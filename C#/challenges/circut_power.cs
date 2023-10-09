using System;

class Challenge5 
{
    
    static void Main(string[] args) 
    {
        Console.WriteLine(CircuitPower(230, 10));
        Console.WriteLine(CircuitPower(110, 3));
        Console.WriteLine(CircuitPower(480, 20));
    }
    
    static int CircuitPower(int voltage, int current) 
    {
        return voltage * current;
    }
    
}
