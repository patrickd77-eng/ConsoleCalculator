using System.Data;
using ConsoleCalculator.Colors;
namespace ConsoleCalculator.Calculation
{
    public class Calculate
    {
        public static string Calculation(string? numberOne, string? operand, string? numberTwo)
        {
            try
            {
                string math = numberOne + operand + numberTwo;
                string? result = "The result is: \n" + new DataTable().Compute(math, null).ToString();
                return result ?? "No result, try again.";
            }
            catch (SyntaxErrorException e)
            {
                throw new Exception("Invalid syntax, try again: " + e);
            }
        }
    }
}