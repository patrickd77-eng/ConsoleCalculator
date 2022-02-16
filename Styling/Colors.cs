namespace ConsoleCalculator.Colors
{
    public class Colors
    {
        public static void MakeConsoleGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void ResetConsole()
        {
            Console.ResetColor();
        }
    }
}