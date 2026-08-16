namespace C_Programming_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password password = new Password(12, true, true);
            Console.WriteLine(password.Generate());
        }
    }
}
