// See https://aka.ms/new-console-template for more information
using Day02;

double a = 12345667;
int b = (int)a;

byte num= 255;
int num2 = num;  // Implicit conversion from byte to int    
Console.WriteLine($"Implicit conversion from byte to int: {num2}"); 

// String to int conversion

String str = "123456";
int result = 0;
if (int.TryParse(str, out result))
{
    Console.WriteLine($"Conversion successful: {result}");
}
else
{
    Console.WriteLine("Conversion failed.");
}

StackHeapExample stackHeapExample = new StackHeapExample();
stackHeapExample.AddFive(10);


