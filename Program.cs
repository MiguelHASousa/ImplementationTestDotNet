namespace ImplementationTestDotNetFive;

public class ImplementationTestDotNet
{
    static void Main()
    {
        //New logic operators in C# version 9.0
        LogicOperators();
    }

    private static void LogicOperators()
    {
        ConsoleWriteText("Enter a new value (It can be text or null or empty)");
        var Text = ConsoleReadLine();

        // Comparing 'Text' variable with null or empty
        if (Text is null or "")
            ConsoleWriteText("Text Null or Empty");

        ConsoleWriteText("Enter a new value (you can write 'Size')");
        var SizeText = ConsoleReadLine();

        // Comparing 'SizeText' with a null or empty value and text 'Size'
        if (SizeText is (not null or "") and "Size")
            ConsoleWriteText($"The String size is {SizeText.Length}");
    }

    private static void ConsoleWriteText(string? text) => Console.WriteLine(text);

    private static string? ConsoleReadLine() => Console.ReadLine();
}
