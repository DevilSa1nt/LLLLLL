namespace LLLLLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calc c = new calc();

            List<Tuple<string, string>> t = new();

            t.Add(new("капот", "синий"));

            double s = c.Calc(t);

            Console.WriteLine(s);
        }
    }
}
