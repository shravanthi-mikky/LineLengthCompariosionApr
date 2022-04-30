// See https://aka.ms/new-console-template for more information
using LineLength;

Console.WriteLine("Welcome to Line Comparision Computation Program!");
//creating objects
UC1 uc1 = new();
Uc2_CompareUsingEquals equals = new();
CompareTo_uc3 compare = new();
//taking input for first line coordinates
Console.WriteLine("Enter the values of x1,y1,x2,y2");
double x1 = uc1.Input();
double x2 = uc1.Input();
double y1 = uc1.Input();
double y2 = uc1.Input();
//distance of line 1
double finalResult = uc1.Distance(x1, x2, y1, y2);
Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);
//taking input for second line coordinates
Console.WriteLine("Enter the values of p,q,r,s");
double p = uc1.Input();
double r = uc1.Input();
double q = uc1.Input();
double s = uc1.Input();
//distance of line 2
double finalResult2 = uc1.Distance(p, r, q, s);
Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", p, q, r, s, finalResult2);
//calling method from uc2 to compare lenthgs using Equals
equals.ComparisionByEquals(finalResult, finalResult2);
//calling method from uc2 to compare lenthgs using CompareTo
compare.CompareToMethod(finalResult, finalResult2);
