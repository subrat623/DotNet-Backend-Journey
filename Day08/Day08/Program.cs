// See https://aka.ms/new-console-template for more information
using Day08;

Console.WriteLine("Enter the measurement : ");
double measurement = Convert.ToDouble(Console.ReadLine());
switch (measurement)
{
    case <0.0:
        Console.WriteLine("Invalid measurement");
        break;
        case >= 0.0 and < 10.0:
            Console.WriteLine("Measurement is less than 10");
            break;
        case >= 10.0 and < 20.0:
            Console.WriteLine("Measurement is between 10 and 20");
            break;
        case double.NaN:
            Console.WriteLine("Measurement is not a number");
            break;
        default:
            Console.WriteLine("Measurement is greater than or equal to 20");
            break;
}

State state = State.active;
switch(state)
{
    case State.active:
        Console.WriteLine("State is active");
        break;
    case State.inactive:
        Console.WriteLine("State is inactive");
        break;
    default:
        Console.WriteLine("Unknown state");
        break;
}

var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
foreach(var number in fibNumbers)
{
   Console.WriteLine($"Fibonacci number: {number}");
}