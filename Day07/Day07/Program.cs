// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your age: ");
int age = int.Parse(Console.ReadLine());
if (age>=18)
{     Console.WriteLine("eligible to vote");
}
else
{
    Console.WriteLine("Not eligible to vote");
}

Console.WriteLine("Enter your Mark: ");
int mark = int.Parse(Console.ReadLine());
if (mark>=90)
{
    Console.WriteLine("Grade A");
}
else if (mark>=80)
{
    Console.WriteLine("Grade B");
}
else if (mark>=70)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Grade D");
}

Console.WriteLine("Enter your password: ");
string password = Console.ReadLine();
if(password=="admin123")
{
    Console.WriteLine("login successful");
}
else
{
    Console.WriteLine("Invalid password");
}

Console.WriteLine("do you have driving license: ");
string license = Console.ReadLine();
Console.WriteLine("enter your age: ");
int drivingage = int.Parse(Console.ReadLine());
if(license=="yes" && drivingage>=18)
{
    Console.WriteLine("eligible to drive");
}
else
{
    Console.WriteLine("Not eligible to drive");
}