using ConsoleCalculator.Calculation;
using ConsoleCalculator.Validation;
using ConsoleCalculator.Colors;

var programActive = true;

do
{
    Colors.MakeConsoleGreen();
    Console.WriteLine("Please enter a number....");
    Colors.ResetConsole();
    string? numberOne = Console.ReadLine();

    Colors.MakeConsoleGreen();
    Console.WriteLine("Please enter an operator... EG + OR - OR * OR / OR %");
    Colors.ResetConsole();
    string? operand = Console.ReadLine();

    Colors.MakeConsoleGreen();
    Console.WriteLine("Please enter a second number....");
    Colors.ResetConsole();
    string? numberTwo = Console.ReadLine();

    if (Validate.ValidateNumber(numberOne ?? string.Empty) && Validate.ValidateNumber(numberTwo ?? string.Empty) && Validate.ValidateOperand(operand ?? string.Empty))
    {
        var result = Calculate.Calculation(numberOne, operand, numberTwo);
        Colors.MakeConsoleGreen();
        Console.WriteLine("The result is: " + result);
        Colors.ResetConsole();
        programActive = Validate.ContinueUsing();
    }
    else
    {
        Console.WriteLine("You entered an invalid input. You need to try again.");
    }

}
while (programActive);