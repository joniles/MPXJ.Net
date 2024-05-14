namespace Samples
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Converting from MPP to MPX");
            new Convert().Execute();
            System.Console.WriteLine();

            System.Console.WriteLine("Listing tasks in an MPP file");
            new ExtractData().Execute();
            System.Console.WriteLine();
        }
    }
}
