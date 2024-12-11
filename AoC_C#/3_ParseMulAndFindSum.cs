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

    // Method to parse the input and calculate the sum of valid multiplications
    public int ParseAndMultiply()
    {
        // Regex pattern for mul() instructions and do()/don't() instructions
        string mulPattern = @"mul\((\d+),(\d+)\)";
        string togglePattern = @"\b(do|don't)\(\)";

        // Match collections for mul() and toggle instructions
        MatchCollection mulMatches = Regex.Matches(inputString, mulPattern);
        MatchCollection toggleMatches = Regex.Matches(inputString, togglePattern);

        int sum = 0;
        bool isEnabled = true;
        int toggleIndex = 0;

        // Process the input string and apply do() and don't() to corresponding mul()
        foreach (Match mulMatch in mulMatches)
        {
            // Process toggle instructions up until the current mul instruction
            while (toggleIndex < toggleMatches.Count && toggleMatches[toggleIndex].Index < mulMatch.Index)
            {
                string toggleValue = toggleMatches[toggleIndex].Value;
                if (toggleValue == "do()")
                {
                    isEnabled = true;
                }
                else if (toggleValue == "don't()")
                {
                    isEnabled = false;
                }
                toggleIndex++;
            }

            // If mul() is enabled by the most recent do() instruction
            if (isEnabled)
            {
                int x = int.Parse(mulMatch.Groups[1].Value);
                int y = int.Parse(mulMatch.Groups[2].Value);
                sum += x * y;
            }
        }

        return sum; // Return the sum of enabled multiplications
    }
}