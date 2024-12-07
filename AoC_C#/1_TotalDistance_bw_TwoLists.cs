
namespace AoC_1
{
    public class TotalDistanceCalculator
    {

        public static long FindTotalDistanceBetweenTwoLists(string filePath)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            FillTwoLists(list1, list2, filePath);

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

        public static void FillTwoLists(List<int> list1, List<int> list2, string filePath)
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

    }

}