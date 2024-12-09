using System.Text.RegularExpressions;
using System.Linq;

namespace AoC_3;
class MulParseAndSum
{
    string? inputString;
    public MulParseAndSum(string filePath)
    {
        ReadInputData(filePath);
    }
    public void ReadInputData(string filePath)
    {

        if (!File.Exists(filePath))
            throw new FileNotFoundException($"The input file not found: {filePath}");

        inputString = File.ReadAllText(filePath);
    }


    public Decimal ParseAndMultiply()
    {
        Decimal totalSum = 0;
        try
        {
            if (inputString == null)
                throw new ArgumentNullException(nameof(inputString), "Input cannot be null.");

            string pattern = @"mul\((\d{1,3}),(\d{1,3})\)";

            MatchCollection matches = Regex.Matches(inputString, pattern);

            totalSum = matches.Cast<Match>()

                                   .Select(match =>
                                   {
                                       int num1 = int.Parse(match.Groups[1].Value);
                                       int num2 = int.Parse(match.Groups[2].Value);
                                       return num1 * num2;
                                   })
                                   .Sum();

            Console.WriteLine($" Matches Count = {matches.Count} , totalSum = {totalSum} ");
        }
        catch (Exception Ex)
        {
            Console.WriteLine($"Error processing input data from the file: {Ex.Message}");
            throw;
        }
        return totalSum;
    }
}