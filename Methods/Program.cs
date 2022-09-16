class Program
{
    public static string testinput = "29535123p48723487597645723645";
    public static long temp = 0; // stores value for addition
    public static long sum = 0;  // stores value for addition

    static void Main(string[] args)
    {
        NumberSequence(testinput);
        Console.ReadKey();
    }

    private static void NumberSequence(string sequence)
    {
        // Index from left to right
        for (int startPos = 0; startPos < sequence.Length - 1; startPos++)
        {
            // Reversing first loop
            for (int endPos = sequence.Length - 1; endPos > startPos; endPos--)
            {
                // If match check for only digits
                if (sequence[startPos] == sequence[endPos])
                {
                    if (sequence.Substring(startPos, endPos - startPos).OnlyNumChar())
                        GetResult(testinput, startPos, endPos);
                }
            }
        }

    }

    public static void GetResult(string sequence, int fromPos, int toPos)
    {
        // remember first colour
        var originalColor = Console.ForegroundColor;
        // Print the part before the hit
        Console.Write(sequence.Substring(0, fromPos));
        // change colour
        Console.ForegroundColor = ConsoleColor.Green;
        // print match
        Console.Write(sequence.Substring(fromPos, toPos - fromPos + 1));

        // math for addition of strings, converting datatype and storing in global variable 
        var numbHold = sequence.Substring(fromPos, toPos - fromPos + 1);
        temp = long.Parse(numbHold);
        sum = temp + sum;

        // change colour back
        Console.ForegroundColor = originalColor;
        // if there is numbers left print them
        if (toPos < sequence.Length - 1)
            Console.Write(sequence.Substring(toPos + 1));
        // print the combined added value of the strings
        Console.Write($" Total sum of substrings:{sum}"); 

        // add a newline
        Console.WriteLine();
    }
}
static class StringExtensions
{
    // exention method for string
    public static bool OnlyNumChar(this string str)
    {
        // checking for 0 - 9 digits, returns false/true
        return !str.Any(c => c < '0' || c > '9');
    }
}
