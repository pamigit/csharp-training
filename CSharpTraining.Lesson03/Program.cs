class Program
{
    static void Main()
    {
        var addition = 1 + 2;
        System.Console.WriteLine($"1 + 2 = {addition}");

        var subtraction = 3 - 2;
        System.Console.WriteLine($"3 - 2 = {subtraction}");

        var multiplication = 2 * 4;
        System.Console.WriteLine($"2 * 4 = {multiplication}");

        var division = 5 / 2;
        System.Console.WriteLine($"5 / 2 = {division}");

        var modulo = 5 % 2;
        System.Console.WriteLine($"5 % 2 = {modulo}");

        addition++;
        System.Console.WriteLine($"addition++ = {addition}");

        subtraction--;
        System.Console.WriteLine($"subtraction-- = {subtraction}");

        //var division = 5.0 / 2.0;
        //System.Console.WriteLine($"5.0 / 2.0 = {division}");

        // This line will prevent the console window from closing immediately.
        System.Console.ReadLine();
    }
}