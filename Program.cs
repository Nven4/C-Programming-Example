namespace C_Programming_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trieangle triangle = new Trieangle(5);
            triangle.symbol = '1';
            triangle.GenTriangle();
            triangle.symbol = '^';
            triangle.GenTriangle();
        }
    }
}
