
using AoC_1;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Main program to inoke AoC solution implementations!");

//1a. To find the total distance between the left list and the right list
TotalDistanceCalculator objTotDistanceCalc = new TotalDistanceCalculator(@"misc/input1.txt");
long result = objTotDistanceCalc.FindTotalDistanceBetweenTwoLists(@"misc/input1.txt");
Console.WriteLine( "total distance between the left list and the right list = " + result);


//1b. To find the total distance between the left list and the right list
long similarityScoreTotal = objTotDistanceCalc.FindSimilarityScore();
Console.WriteLine( "total similarity score of list1 elements against list2  = " + similarityScoreTotal);