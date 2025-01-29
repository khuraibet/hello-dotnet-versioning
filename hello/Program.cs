namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        var number = int.Parse(Console.ReadLine() ?? String.Empty);

        Console.WriteLine("You entered the number " + number);
    }
}
