
using AoC_1;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Main program to inoke AoC solution implementations!");

//1a. To find the total distance between the left list and the right list
long result = TotalDistanceCalculator.FindTotalDistanceBetweenTwoLists(@"misc/input1.txt");
Console.WriteLine( "total distance between the left list and the right list = " + result);