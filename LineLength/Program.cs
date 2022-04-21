﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Line Comparision Computation Program!");
Console.WriteLine("Please Enter x1 and y1 coordinates ");
var x1 = Convert.ToDouble(Console.ReadLine());
var y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter x2 and y2 coordinates ");
var x2 = Convert.ToDouble(Console.ReadLine());
var y2 = Convert.ToDouble(Console.ReadLine());
var finalResult = Distance(x1, x2, y1, y2);
Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);

static double Distance(double x1, double x2, double y1, double y2)
{
    var temp1 = Math.Pow((x2 - x1), 2);
    var temp2 = Math.Pow((y2 - y1), 2);
    var result = Math.Sqrt(temp1 + temp2);
    return result;
}
Console.WriteLine("Please Enter p and q coordinates ");
var p = Convert.ToDouble(Console.ReadLine());
var q = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter x2 and y2 coordinates ");
var r = Convert.ToDouble(Console.ReadLine());
var s = Convert.ToDouble(Console.ReadLine());
var finalResult2 = Distance(p, r, q, s);
Console.WriteLine("Distance between {0},{1} and {2},{3} is {4:F}", p, q, r, s, finalResult2);
////Method to compare the line lenthgs using the Equals operator

static void ComparisionByEquals(double finalResult, double finalResult2)
{
    bool status = finalResult.Equals(finalResult2);
    if (status)
        Console.WriteLine("{0} is equal to {1}", finalResult, finalResult2);
    else
        Console.WriteLine("{0} is not equal to {1}", finalResult, finalResult2);
}
//ComparisionByEquals(finalResult,finalResult2);
//Method to compare the line lenthgs using the CompareTo Method
static void ComparisionByCompareTo(double finalResult, double finalResult2)
{
    int res = finalResult.CompareTo(finalResult2);
    Console.WriteLine(res);
    if (res == 0)
    {
        Console.WriteLine("Lengths are equal!");
    }
    if (res >= 0)
    {
        Console.WriteLine("Line 1 is greator than line 2 ");
    }
    else
    {
        Console.WriteLine("Line 2 is greator than line 1 ");
    }
}
ComparisionByCompareTo(finalResult, finalResult);