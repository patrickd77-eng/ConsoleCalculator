using ConsoleCalculator.Calculation;
using ConsoleCalculator.Validation;


var programActive = true;

do
{

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter a number....");
    Console.ResetColor();
    string numberOne = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter an operand... EG + OR - OR * OR / OR %");
    Console.ResetColor();
    string operand = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter a second number....");
    Console.ResetColor();
    string numberTwo = Console.ReadLine();


    if (Validate.ValidateNumber(numberOne) && Validate.ValidateNumber(numberTwo) && Validate.ValidateOperand(operand))
    {
        var result = Calculate.Calculation(numberOne, operand, numberTwo);
        Console.WriteLine("The result is: " + result);
        programActive = Validate.ContinueUsing();

    }
    else
    {
        Console.WriteLine("You enteGreen an invalid input. You need to try again.");

    }

}
while (programActive);







