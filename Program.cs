namespace C_Programming_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caesar caeser = new Caesar("hello, world!", 5);
            Console.WriteLine(caeser.Coding());
            Console.WriteLine((string)caeser);
        }
    }
}
