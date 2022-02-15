using ConsoleCalculator.Calculation;
using ConsoleCalculator.Validation;


var programActive = true;

do
{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter a number....");
    Console.ForegroundColor = ConsoleColor.White;
    string numberOne = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter an operand... EG + OR - OR * OR / OR %");
    Console.ForegroundColor = ConsoleColor.White;
    string operand = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter a second number....");
    Console.ForegroundColor = ConsoleColor.White;
    string numberTwo = Console.ReadLine();


    if (Validate.ValidateNumber(numberOne) && Validate.ValidateNumber(numberTwo) && Validate.ValidateOperand(operand))
    {
        var result = Calculate.Calculation(numberOne, operand, numberTwo);
        Console.WriteLine("The result is: " + result);
        programActive = Validate.ContinueUsing();

    }
    else
    {
        Console.WriteLine("You entered an invalid input. You need to try again.");

    }

}
while (programActive);







