using System;

class Challenge2 {
    static void Main(string[] args) {
        Console.WriteLine(LessThanOrEqualToZero(5));
        Console.WriteLine(LessThanOrEqualToZero(0));
        Console.WriteLine(LessThanOrEqualToZero(-2));
    }
    static bool LessThanOrEqualToZero(int num) {
        return num <= 0;
    }
}
