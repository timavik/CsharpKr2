public static class IntExtensions
{
    public static string ToWords(this int number)
    {
        string[] units = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        return string.Join(" ", number.ToString().Select(digit => units[int.Parse(digit.ToString())]));
    }
}