using ConsoleCalculator.Calculation;
using ConsoleCalculator.Validation;
using ConsoleCalculator.Colors;

var programActive = true;

Colors.MakeConsoleCyan();
Console.WriteLine("This is a freetext calculator that takes in a sring, eg \"5 + 5\", and returns the result.");
Console.ResetColor();

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
        Colors.MakeConsoleGreen();
        Console.WriteLine(Calculate.Calculation(numberOne, operand, numberTwo));
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