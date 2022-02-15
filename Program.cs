using ConsoleCalculator.Calculation;
using ConsoleCalculator.Validation;



Console.WriteLine("Please enter a number....");
string numberOne = Console.ReadLine();

Console.WriteLine("Please enter an operand... EG + OR - OR * OR / OR %");
string operand = Console.ReadLine();

Console.WriteLine("Please enter a second number....");
string numberTwo = Console.ReadLine();

Console.WriteLine("The result is: " + Calculate.Calculation(numberOne,operand,numberTwo));

