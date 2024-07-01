class Program
{
    static void Main()
    {
        
        string text = Console.ReadLine();

        
        int repeatCount = int.Parse(Console.ReadLine());

        string repeatedText = RepeatStringWithoutSpace(text, repeatCount);
        Console.WriteLine(repeatedText);
    }

    static string RepeatStringWithoutSpace(string text, int repeatCount)
    {
        string result = "";
        for (int i = 0; i < repeatCount; i++)
        {
            result += text;
        }
        return result;
    }
}