Random rnd = new Random();
char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '};
int _numOfLinesToPrint = 10;
string uinput = string.Empty;
WaitForInput();

void WaitForInput()
{
    Console.WriteLine("How many letters? Press 'C' followed by enter to close.");
    try
    {
         uinput = Console.ReadLine().ToLower();
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid input somehow");
        throw;
    }
    if(uinput != "c")
    {
        try
        {
            LinesOfGibberish(Convert.ToInt32(uinput));
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Invalid format.");
            WaitForInput();
        }
    }
    else
    {
        Environment.Exit(0);
    }
}

void LinesOfGibberish(int numOfLines)
{
    for (int y = 0; y < _numOfLinesToPrint; y++)
    {
        for (int x = 0; x < numOfLines; x++)
        {
            Console.Write(chars[rnd.Next(chars.Length)]);
        }
        Console.WriteLine();
        Console.Beep(); // I love the beeps.
    }
    WaitForInput();
}