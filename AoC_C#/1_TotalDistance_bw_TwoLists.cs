
namespace AoC_1
{
    public class TotalDistanceCalculator
    {

        private List<int> list1 = new List<int>();
        private List<int> list2 = new List<int>();

        public TotalDistanceCalculator(string filePath)
        {
            FillTwoLists(filePath);
        }

        public long FindTotalDistanceBetweenTwoLists(string filePath)
        {
            if (list1.Count != list2.Count)
                throw new InvalidOperationException("mismatched number of elements.");

            // Sort both lists
            list1.Sort();
            list2.Sort();

            long totalDistance = 0;
            for (int i = 0; i < list1.Count; i++)
            {
                totalDistance += Math.Abs(list1[i] - list2[i]);
            }

            return totalDistance;
        }

        public void FillTwoLists(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"The input file not found: {filePath}");

            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 2)
                    {
                        Console.WriteLine($" The line is not parsable: {line}");
                        continue;
                    }

                    list1.Add(int.Parse(parts[0]));
                    list2.Add(int.Parse(parts[1]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing input data from the file: {ex.Message}");
                throw;
            }
        }

        public long FindSimilarityScore()
        {
            long similarityScoreTotal = 0;
            for (int i = 0; i < list1.Count -1; i++)
            {
                long similarityScore = 0;
                for (int j = 0; j < list2.Count - 1; j++)
                {
                    // Both Lists are sorted. 
                    // Once an element of list1 is < the list2[n], lets stop look for similarity further
                    if(list1[i] == list2[j])
                    {
                        similarityScore += list1[i];
                    }
                    else if(list1[i] < list2[j])
                    {
                        break;
                    }
                }
                similarityScoreTotal += similarityScore;
            }

            return similarityScoreTotal;
        }

    }

}