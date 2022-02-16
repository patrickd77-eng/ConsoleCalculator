using ConsoleCalculator.Calculation;
using ConsoleCalculator.Validation;
using ConsoleCalculator.Colors;

var programActive = true;

do
{
    Colors.MakeConsoleGreen();
    Console.WriteLine("Please enter a number: EG 5");
    Console.ResetColor();
    string? numberOne = Validate.GetAndValidateNumber();

    Colors.MakeConsoleGreen();
    Console.WriteLine("Please enter an operator: EG + - * / %");
    Console.ResetColor();
    string? operand = Validate.GetAndValidateOperator();

    Colors.MakeConsoleGreen();
    Console.WriteLine("Please enter a second number: EG 6");
    Console.ResetColor();
    string? numberTwo = Validate.GetAndValidateNumber();

    if (numberOne != "Invalid" && numberTwo != "Invalid" && operand != "Invalid")
    {
        var result = Calculate.Calculation(numberOne, operand, numberTwo);
        Colors.MakeConsoleGreen();
        Console.WriteLine("The result is: " + result);
        Console.ResetColor();
        programActive = Validate.ContinueUsing();
    }
    else
    {
        Colors.MakeConsoleRed();
        Console.WriteLine("You entered an invalid input. You need to try again.");
        Console.ResetColor();
    }

}
while (programActive);