// See https://aka.ms/new-console-template for more information


List<string> lst = new List<string>();
lst.Add("ironman");
lst.Add("captain marvel");
lst.Add("Black panther");

//adding new item in array 
Console.WriteLine("enter the favorite movie");
lst.Add(Console.ReadLine());


//int count = lst.Count;
//remove
lst.Remove("captain marvel");
foreach (string prt in lst)
{
    Console.WriteLine(prt);
}
;
Console.WriteLine(lst[1]);
Console.WriteLine("total count="+ lst.Count);


