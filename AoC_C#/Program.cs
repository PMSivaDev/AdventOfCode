
using AoC_1;
using  AoC_2;
using AoC_3;
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

        //----------------------------------------------------------------------------------------------------------------------


        //2a. To find the total distance between the left list and the right list
        
        RedNosedReports objRedNosedReports = new RedNosedReports(@"/media/sk/D/repo/Ubu/AdventOfCode/AoC_C#/misc/input2.txt");
        int safeRecordsCount = objRedNosedReports.AnalyseSafetyOfReportsData();
        Console.WriteLine($"After analysis, total number of safety records found =  {safeRecordsCount}" );

        // -------------------------------------------------------------------------
        //3a. Parse the input data for the pattern "mul(11,22)". Do perform 'multiply' and then sum all.
        MulParseAndSum objMulParseAndSum = new MulParseAndSum(@"/media/sk/D/repo/Ubu/AdventOfCode/AoC_C#/misc/input3.txt");
        Decimal result3 = objMulParseAndSum.ParseAndMultiply();
        Console.WriteLine($"Sum of all parsed and multiplied result  =  {result3}" );


    }
}