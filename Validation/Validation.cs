using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleCalculator.Validation
{
    public class Validate
    {
        public static string GetAndValidateNumber()
        {
            string? userInput = Console.ReadLine() ?? String.Empty;
            NumberStyles style = NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint;

            //If number
            if (double.TryParse(userInput, style, CultureInfo.InvariantCulture, out var result))
            {
                return result.ToString();
            }
            else
            {
                return "Invalid";
            }
        }

        public static string GetAndValidateOperator()
        {
            string? userInput = Console.ReadLine() ?? String.Empty;

            if (!Regex.IsMatch(userInput, "[a-z0-9 ]+", RegexOptions.IgnoreCase))
            {
                return userInput;
            }
            else
            {
                return "Invalid";
            }
        }
        public static bool ContinueUsing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter 'Y' to continue or any other key to quit.");
            Console.ResetColor();
            string answer = Console.ReadLine() ?? string.Empty;
            if (answer.ToString().Trim().ToUpper() == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}