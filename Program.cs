namespace LLLLLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inp_out inp = new();
            calc c = new calc();

            List<Tuple<string, string>> data = inp.input_d();

            Console.WriteLine("Производится расчёт");
            List<Tuple<string, string>> t = new();

            t.Add(new("капот", "синий"));

            double s = c.Calc(t);

            Console.WriteLine(s);
        }
    }
}
