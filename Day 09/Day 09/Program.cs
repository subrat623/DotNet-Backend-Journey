// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("enter the first number:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the Second number:");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("The Division of the two numbers is: " + (a / b));

}
catch
{
    Console.WriteLine("Error: Division by zero is not allowed.");
}
finally
{
    Console.WriteLine("Press any key to exit...");

}



 static void checkage(int age)
{
    if (age < 18)
    {
        throw new Exception("Age must be at least 18.");
    }
    else
    {
        Console.WriteLine("Age is valid.");
    }
}

try { 
    checkage(15); // This will throw an exception
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}












