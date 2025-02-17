namespace KrNumber3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> numbers = new List<int> { 5, 3, 8, 1, 6, 2, 9, 4 };

                var sorted = numbers.OrderBy(n => n);

                int halfIndex = (int)Math.Ceiling(numbers.Count / 2.0);

                var result = sorted.Skip(halfIndex)
                                   .OrderByDescending(n => n)
                                   .Select(n => n * n);

                Console.WriteLine(string.Join(", ", result)); 
                Console.ReadKey();
            }
        }
    }
}
