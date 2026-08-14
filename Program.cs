namespace C_Programming_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = Convert.ToInt16(Console.ReadLine());
            int minute = Convert.ToInt16(Console.ReadLine());

            Degree degree = new Degree(hour, minute);

            Console.WriteLine("Большее значение: " + degree.big + " " + "Меньшее значение: " + degree.small);
        }
    }
}
