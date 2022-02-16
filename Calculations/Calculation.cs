using System.Data;
namespace ConsoleCalculator.Calculation
{
    public class Calculate
    {
        public static string Calculation(string? numberOne, string? operand, string? numberTwo)
        {

            string math = numberOne + operand + numberTwo;

            string ?result = new DataTable().Compute(math, null).ToString();

            return result ?? "No result.";
        }
    }
}