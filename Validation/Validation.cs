namespace ConsoleCalculator.Validation
{
    public class Validate
    {
        public static bool ValidateNumber(string input)
        {
            var valid = true;
            //todo
            return valid;
        }

        public static bool ValidateOperand(string? input)
        {
            var valid = true;
            //todo
            return valid;
        }

        public static bool ContinueUsing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter 'Y' to continue or any other key to quit.");
            Console.ResetColor();
            string answer = Console.ReadLine() ?? string.Empty;
            if (answer.ToString().Trim().ToUpper() == "Y" )
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