// See https://aka.ms/new-console-template for more information
using Day10;

List<Employee> employees = new()
{
    new Employee{ Id=1, Name="Subrat", Age=25, Salary=50000, IsActive=true},
    new Employee{ Id=2, Name="Rahul", Age=30, Salary=70000, IsActive=true},
    new Employee{ Id=3, Name="Amit", Age=22, Salary=30000, IsActive=false},
    new Employee{ Id=4, Name="Sourav", Age=28, Salary=90000, IsActive=true},
    new Employee{ Id=5, Name="Rakesh", Age=24, Salary=40000, IsActive=false},
};

List<int> numbers = new()
{
    10,20,30,40,50
};

foreach(var num in numbers)
{
    if (num > 30) 
    { Console.WriteLine(num);
    }
};
List<string> names = new()
{
    "Subrat",
    "Rahul",
    "Amit",
    "Sourav",
    "Rakesh"
};
var result= names.Where(n => n.StartsWith("S"));
foreach(var name in result)
{
    Console.WriteLine(name);
}

var id= employees.Select(employees => employees.Id);
foreach(var i in id)
{
    Console.WriteLine(i);
}