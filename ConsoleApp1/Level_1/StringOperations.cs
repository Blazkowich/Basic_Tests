namespace Pale_Tasks.Level_1;

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

    public static void CallStringOperations(int delay)
    {
        Console.WriteLine("String Operations");
        Console.WriteLine("------------------");

        bool allSuccess = true;

        Thread.Sleep(delay);
        bool test1 = Concatenate("Hello", "World") == "HelloWorld";
        Console.WriteLine($"Concatenate 2: {(test1 ? "[OK]" : "[X]")}");
        allSuccess &= test1;

        Thread.Sleep(delay);
        bool test2 = Concatenate("C#", "is", "fun") == "C#isfun";
        Console.WriteLine($"Concatenate 3: {(test2 ? "[OK]" : "[X]")}");
        allSuccess &= test2;

        Thread.Sleep(delay);
        string expectedSplit = "[ " + string.Join(", ", Split("I Overcame My Fears", ' ')) + " ]";
        bool test3 = expectedSplit == "[ I, Overcame, My, Fears ]";
        Console.WriteLine($"Split: {(test3 ? "[OK]" : "[X]")}");
        allSuccess &= test3;

        Thread.Sleep(delay);
        bool test4 = Replace("I/Overcame/My/Fears", '/', ' ') == "I Overcame My Fears";
        Console.WriteLine($"Replace: {(test4 ? "[OK]" : "[X]")}");
        allSuccess &= test4;

        Thread.Sleep(delay);
        bool test5 = GetLength("Hello") == 5;
        Console.WriteLine($"Get Length: {(test5 ? "[OK]" : "[X]")}");
        allSuccess &= test5;

        Thread.Sleep(delay);
        bool test6 = ToUpperCase("abc") == "ABC";
        Console.WriteLine($"To Upper Case: {(test6 ? "[OK]" : "[X]")}");
        allSuccess &= test6;

        Thread.Sleep(delay);
        bool test7 = ToLowerCase("XYZ") == "xyz";
        Console.WriteLine($"To Lower Case: {(test7 ? "[OK]" : "[X]")}");
        allSuccess &= test7;

        Thread.Sleep(delay);
        bool test8 = ContainsSubstring("Hello World", "World") == true;
        Console.WriteLine($"Contains Substring: {(test8 ? "[OK]" : "[X]")}");
        allSuccess &= test8;

        Thread.Sleep(delay);
        bool test9 = StartsWith("OpenAI", "Open") == true;
        Console.WriteLine($"Starts With: {(test9 ? "[OK]" : "[X]")}");
        allSuccess &= test9;

        Thread.Sleep(delay);
        bool test10 = EndsWith("VisualStudio", "Studio") == true;
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
