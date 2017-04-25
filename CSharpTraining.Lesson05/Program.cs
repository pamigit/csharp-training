class Program
{
    static void Main()
    {
        var str = " Hello Everyone! ";
        System.Console.WriteLine($"str: {str}");

        var strUpper = str.ToUpper();
        System.Console.WriteLine($"strUpper: {strUpper}");

        var strLower = str.ToLower();
        System.Console.WriteLine($"strLower: {strLower}");

        var strTrim = str.Trim();
        System.Console.WriteLine($"strTrim: {strTrim}");

        var strChain = str.ToUpper().Trim();
        System.Console.WriteLine($"strChain: {strChain}");

        var strConcat = str + "Today is a fine day!";
        System.Console.WriteLine($"strConcat: {strConcat}");

        System.Console.WriteLine("\nChanging str variable");
        str = "Changed";
        System.Console.WriteLine($"str: {str}");
        System.Console.WriteLine($"strConcat: {strConcat}");

        //var immutable = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
        //System.Console.WriteLine(immutable);
        //immutable = new string(new char[] { 'g', 'o', 'o', 'd', 'b', 'y', 'e' });
        //System.Console.WriteLine(immutable);

        // This line will prevent the console window from closing immediately.
        System.Console.ReadLine();
    }
}