// See https://aka.ms/new-console-template for more information

using Day11;

var myClass = new GenericClass<string>("hello");

void printData<T>(T input) {
    Console.WriteLine(input);
}
printData("hi Subrat");