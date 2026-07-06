// See https://aka.ms/new-console-template for more information

string example = "hello subrat";
//literal
string filePath = "C:\\Users\\Subrat\\Documents\\example.txt";
//verbatim
string verbatimFilePath = @"C:\Users\Subrat\Documents\example.txt";

Console.WriteLine("hello!please enter your first name and last name ");
string firstName = Console.ReadLine();
string lastName = Console.ReadLine();

Console.WriteLine($"welcome {firstName.ToUpper()} {lastName.ToUpper()}");
Console.WriteLine($"{firstName.Length}{lastName.Length}");
Console.WriteLine(firstName.Length);