namespace Pale_Tasks.Level_1;

public class IntegerOperations
{
    // Add Two Integers
    public static int Plus(int x, int y)
    {
        return 0;
    }

    // Subtract Two Integers
    public static int Minus(int x, int y)
    {
        return 0;
    }

    // Multiply Two Integers
    public static int Multiply(int x, int y)
    {
        return 0;
    }

    // Divide Two Integers
    public static int Divide(int x, int y)
    {
        return 0;
    }

    // Modulo of an Integer
    public static int Modulo(int x)
    {
        return -1;
    }

    // Sum of Three Integers
    public static int Sum(int x1, int x2, int x3)
    {
        return 0;
    }

    // Return the Largest Integer
    public static int ReturnLargestInteger()
    {
        return 0;
    }

    // Return the Smallest Integer
    public static int ReturnSmallestInteger()
    {
        return 0;
    }

    // Return Positive Number
    public static int ReturnPositiveNumber(int i)
    {
        return 0;
    }

    // Return Negative Number
    public static int ReturnNegativeNumber(int i)
    {
        return 0;
    }

    public static void CallIntegerOperations(int delay)
    {
        Console.WriteLine("Integer Operations");
        Console.WriteLine("------------------");

        bool allSuccess = true;

        Thread.Sleep(delay);
        bool plus = Plus(1, 1) == 2;
        Console.WriteLine($"Plus: {(plus ? "[OK]" : "[X]")}");
        allSuccess &= plus;

        Thread.Sleep(delay);
        bool minus = Minus(4, 2) == 2;
        Console.WriteLine($"Minus: {(minus ? "[OK]" : "[X]")}");
        allSuccess &= minus;

        Thread.Sleep(delay);
        bool multiply = Multiply(2, 2) == 4;
        Console.WriteLine($"Multiply: {(multiply ? "[OK]" : "[X]")}");
        allSuccess &= multiply;

        Thread.Sleep(delay);
        bool divide = Divide(2, 2) == 1;
        Console.WriteLine($"Divide: {(divide ? "[OK]" : "[X]")}");
        allSuccess &= divide;

        Thread.Sleep(delay);
        bool modulo = Modulo(4) == 0;
        Console.WriteLine($"Modulo: {(modulo ? "[OK]" : "[X]")}");
        allSuccess &= modulo;

        Thread.Sleep(delay);
        bool sum = Sum(1, 1, 1) == 3;
        Console.WriteLine($"Sum: {(sum ? "[OK]" : "[X]")}");
        allSuccess &= sum;

        Thread.Sleep(delay);
        bool maxInt = ReturnLargestInteger() == 2147483647;
        Console.WriteLine($"Return Largest Integer: {(maxInt ? "[OK]" : "[X]")}");
        allSuccess &= maxInt;

        Thread.Sleep(delay);
        bool minInt = ReturnSmallestInteger() == -2147483648;
        Console.WriteLine($"Return Smallest Integer: {(minInt ? "[OK]" : "[X]")}");
        allSuccess &= minInt;

        Thread.Sleep(delay);
        bool positive = ReturnPositiveNumber(-1) == 1;
        Console.WriteLine($"Return Positive Number: {(positive ? "[OK]" : "[X]")}");
        allSuccess &= positive;

        Thread.Sleep(delay);
        bool negative = ReturnNegativeNumber(1) == -1;
        Console.WriteLine($"Return Negative Number: {(negative ? "[OK]" : "[X]")}");
        allSuccess &= negative;

        Console.WriteLine("------------------");

        if (allSuccess)
        {
            Console.WriteLine("[OK] All tasks were done successfully!");
        }
        else
        {
            Console.WriteLine("[X] Some tasks failed. Please review the output above.");
        }
    }
}
