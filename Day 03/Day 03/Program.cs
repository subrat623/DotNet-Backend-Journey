// See https://aka.ms/new-console-template for more information

//fixed array


int[] vs= new int[5]; 
vs[0] = 1; 
vs[1] = 2; 
vs[2] = 3; 
vs[3] = 4; 
vs[4] = 5;
//Console.WriteLine(vs);

//dynamic array
int [] vs2 = new int[] {5,6,7,8,2,3};
Array.Sort(vs2);
double vs3 = vs2.Average();
double vs4 = vs2.Length- 1;
Console.WriteLine(vs3);
//updated index 2 with 100
vs2[2] = 100;


Console.WriteLine(" first number:" + vs2[0]);
Console.WriteLine(" last number:" + vs2[(int)vs4-1]);


