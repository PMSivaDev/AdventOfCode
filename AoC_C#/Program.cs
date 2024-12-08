﻿
using AoC_1;
using  AoC_2;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main program to inoke AoC solution implementations!");

        //1a. To find the total distance between the left list and the right list
        TotalDistanceCalculator objTotDistanceCalc = new TotalDistanceCalculator(@"misc/input1.txt");
        long result = objTotDistanceCalc.FindTotalDistanceBetweenTwoLists(@"misc/input1.txt");
        Console.WriteLine("total distance between the left list and the right list = " + result);


        //1b. To find the total distance between the left list and the right list
        long similarityScoreTotal = objTotDistanceCalc.FindSimilarityScore();
        Console.WriteLine("total similarity score of list1 elements against list2  = " + similarityScoreTotal);

        ----------------------------------------------------------------------------------------------------------------------


        //2a. To find the total distance between the left list and the right list
        RedNosedReports objRedNosedReports = new RedNosedReports(@"/media/sk/D/repo/Ubu/AdventOfCode/AoC_C#/misc/input2.txt");
        int safeRecordsCount = objRedNosedReports.AnalyseSafetyOfReportsData();
        Console.WriteLine($"After analysis, total number of safety records found =  {safeRecordsCount}" );
        // long result2 = objRedNosedReports.FindTotalDistanceBetweenTwoLists(@"misc/input2.txt");
    }
}