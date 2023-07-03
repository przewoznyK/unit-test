using Testy.Console;

Calculator calculator = new Calculator();
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Multiply");
Console.WriteLine("4 - Divide");
bool validInput = false;
int choosedNumberParse = 1;
while(!validInput)
{
    Console.WriteLine("Choose calculation type:");
    string choosedNumber = Console.ReadLine();
    if (int.TryParse(choosedNumber, out choosedNumberParse))
    {
        if (choosedNumberParse >= 1 && choosedNumberParse <= 4)
        {
            validInput = true;
        }
        else Console.WriteLine("The input value is out of range.");
    }
    else Console.WriteLine("Wrong type of value");
}
validInput = false;
float result = 0;
float firstNumberFloat = 0;
while(!validInput)
{
    Console.WriteLine("Type first number: ");
    string firstNumber = Console.ReadLine();
    try
    {
        firstNumberFloat = float.Parse(firstNumber);
        Console.WriteLine($"First Number: {firstNumberFloat}");
        validInput = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Wrong type of number try again:");
    }
}
validInput = false;
float secondNumberFloat = 0;
while(!validInput)
{
     Console.WriteLine("Type second number:");
    string secondNumber = Console.ReadLine();
    try
    {
        secondNumberFloat = float.Parse(secondNumber);
        Console.WriteLine($"Second Number: {secondNumberFloat}");
        validInput = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Wrong type of number try again:");
    }
}

switch (choosedNumberParse)
{
    case 1:
            result = calculator.Add(firstNumberFloat, secondNumberFloat);
            Console.WriteLine("Addition result : " + result);
        break;
    case 2:
            result = calculator.Subtract(firstNumberFloat, secondNumberFloat);
            Console.WriteLine("Subtraction result: " + result);
        break;
    case 3:
            result = calculator.Multiply(firstNumberFloat, secondNumberFloat);
            Console.WriteLine("Multiplication  result: " + result);
        break;
    case 4:
        if (secondNumberFloat != 0)
        {
            result = calculator.Divide(firstNumberFloat, secondNumberFloat);
            Console.WriteLine("Division  result: " + result);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        break;
    default:
        Console.WriteLine("Wrong calculator type.");
        break;
}
