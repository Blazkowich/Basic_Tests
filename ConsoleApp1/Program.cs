namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        CallIntegerOperations(500);
        CallStringOperations(500);
    }

    static void CallIntegerOperations(int delay)
    {
        var integerOps = new IntegerOperations();
        Console.WriteLine("Integer Operations");
        Console.WriteLine("------------------");

        bool allSuccess = true;

        Thread.Sleep(delay);
        bool plus = integerOps.Plus(1, 1) == 2;
        Console.WriteLine($"Plus: {(plus ? "[OK]" : "[X]")}");
        allSuccess &= plus;

        Thread.Sleep(delay);
        bool minus = integerOps.Minus(4, 2) == 2;
        Console.WriteLine($"Minus: {(minus ? "[OK]" : "[X]")}");
        allSuccess &= minus;

        Thread.Sleep(delay);
        bool multiply = integerOps.Multiply(2, 2) == 4;
        Console.WriteLine($"Multiply: {(multiply ? "[OK]" : "[X]")}");
        allSuccess &= multiply;

        Thread.Sleep(delay);
        bool divide = integerOps.Divide(2, 2) == 1;
        Console.WriteLine($"Divide: {(divide ? "[OK]" : "[X]")}");
        allSuccess &= divide;

        Thread.Sleep(delay);
        bool modulo = integerOps.Modulo(4) == 0;
        Console.WriteLine($"Modulo: {(modulo ? "[OK]" : "[X]")}");
        allSuccess &= modulo;

        Thread.Sleep(delay);
        bool sum = integerOps.Sum(1, 1, 1) == 3;
        Console.WriteLine($"Sum: {(sum ? "[OK]" : "[X]")}");
        allSuccess &= sum;

        Thread.Sleep(delay);
        bool maxInt = integerOps.ReturnLargestInteger() == 2147483647;
        Console.WriteLine($"Return Largest Integer: {(maxInt ? "[OK]" : "[X]")}");
        allSuccess &= maxInt;

        Thread.Sleep(delay);
        bool minInt = integerOps.ReturnSmallestInteger() == -2147483648;
        Console.WriteLine($"Return Smallest Integer: {(minInt ? "[OK]" : "[X]")}");
        allSuccess &= minInt;

        Thread.Sleep(delay);
        bool positive = integerOps.ReturnPositiveNumber(-1) == 1;
        Console.WriteLine($"Return Positive Number: {(positive ? "[OK]" : "[X]")}");
        allSuccess &= positive;

        Thread.Sleep(delay);
        bool negative = integerOps.ReturnNegativeNumber(1) == -1;
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

    static void CallStringOperations(int delay)
    {
        Console.WriteLine("String Operations");
        Console.WriteLine("------------------");

        bool allSuccess = true;

        Thread.Sleep(delay);
        bool test1 = StringOperations.Concatenate("Hello", "World") == "HelloWorld";
        Console.WriteLine($"Concatenate 2: {(test1 ? "[OK]" : "[X]")}");
        allSuccess &= test1;

        Thread.Sleep(delay);
        bool test2 = StringOperations.Concatenate("C#", "is", "fun") == "C#isfun";
        Console.WriteLine($"Concatenate 3: {(test2 ? "[OK]" : "[X]")}");
        allSuccess &= test2;

        Thread.Sleep(delay);
        string expectedSplit = "[ " + string.Join(", ", StringOperations.Split("I Overcame My Fears", ' ')) + " ]";
        bool test3 = expectedSplit == "[ I, Overcame, My, Fears ]";
        Console.WriteLine($"Split: {(test3 ? "[OK]" : "[X]")}");
        allSuccess &= test3;

        Thread.Sleep(delay);
        bool test4 = StringOperations.Replace("I/Overcame/My/Fears", '/', ' ') == "I Overcame My Fears";
        Console.WriteLine($"Replace: {(test4 ? "[OK]" : "[X]")}");
        allSuccess &= test4;

        Thread.Sleep(delay);
        bool test5 = StringOperations.GetLength("Hello") == 5;
        Console.WriteLine($"Get Length: {(test5 ? "[OK]" : "[X]")}");
        allSuccess &= test5;

        Thread.Sleep(delay);
        bool test6 = StringOperations.ToUpperCase("abc") == "ABC";
        Console.WriteLine($"To Upper Case: {(test6 ? "[OK]" : "[X]")}");
        allSuccess &= test6;

        Thread.Sleep(delay);
        bool test7 = StringOperations.ToLowerCase("XYZ") == "xyz";
        Console.WriteLine($"To Lower Case: {(test7 ? "[OK]" : "[X]")}");
        allSuccess &= test7;

        Thread.Sleep(delay);
        bool test8 = StringOperations.ContainsSubstring("Hello World", "World") == true;
        Console.WriteLine($"Contains Substring: {(test8 ? "[OK]" : "[X]")}");
        allSuccess &= test8;

        Thread.Sleep(delay);
        bool test9 = StringOperations.StartsWith("OpenAI", "Open") == true;
        Console.WriteLine($"Starts With: {(test9 ? "[OK]" : "[X]")}");
        allSuccess &= test9;

        Thread.Sleep(delay);
        bool test10 = StringOperations.EndsWith("VisualStudio", "Studio") == true;
        Console.WriteLine($"Ends With: {(test10 ? "[OK]" : "[X]")}");
        allSuccess &= test10;

        Console.WriteLine("------------------");

        if (allSuccess)
        {
            Console.WriteLine("[OK] All string tasks were done successfully!");
        }
        else
        {
            Console.WriteLine("[X] Some string tasks failed. Please review the output above.");
        }
    }
}

public class IntegerOperations
{
    // Add Two Integers
    public int Plus(int x, int y)
    {
        return 0;
    }

    // Subtract Two Integers
    public int Minus(int x, int y)
    {
        return 0;
    }

    // Multiply Two Integers
    public int Multiply(int x, int y)
    {
        return 0;
    }

    // Divide Two Integers
    public int Divide(int x, int y)
    {
        return 0;
    }

    // Modulo of an Integer
    public int Modulo(int x)
    {
        return -1;
    }

    // Sum of Three Integers
    public int Sum(int x1, int x2, int x3)
    {
        return 0;
    }

    // Return the Largest Integer
    public int ReturnLargestInteger()
    {
        return 0;
    }

    // Return the Smallest Integer
    public int ReturnSmallestInteger()
    {
        return 0;
    }

    // Return Positive Number
    public int ReturnPositiveNumber(int i)
    {
        return 0;
    }

    // Return Negative Number
    public int ReturnNegativeNumber(int i)
    {
        return 0;
    }
}

public class StringOperations
{
    // Concatenate Two Strings
    public static string Concatenate(string str1, string str2)
    {
        return string.Empty;
    }

    // Concatenate Three Strings
    public static string Concatenate(string str1, string str2, string str3)
    {
        return string.Empty;
    }

    // Split Strings
    public static string[] Split(string str, char byWithChar)
    {
        return [];
    }

    // Replace Characters
    public static string Replace(string str, char charToReplace, char byWithChar)
    {
        return string.Empty;
    }

    // Get Length of a String
    public static int GetLength(string str)
    {
        return -1;
    }

    // Convert String to UPPER Case
    public static string ToUpperCase(string str)
    {
        return string.Empty;
    }

    // Convert String to lower Case
    public static string ToLowerCase(string str)
    {
        return string.Empty;
    }

    // Check if String Contains Substring
    public static bool ContainsSubstring(string source, string substring)
    {
        return false;
    }

    // Check if String Starts with a Prefix
    public static bool StartsWith(string source, string prefix)
    {
        return false;
    }

    // Check if String Ends with a Suffix
    public static bool EndsWith(string source, string suffix)
    {
        return false;
    }
}