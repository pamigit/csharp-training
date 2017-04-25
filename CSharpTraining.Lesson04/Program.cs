class Program
{
    static void Main()
    {
        var isTrue = true;
        var isFalse = false;

        System.Console.WriteLine("AND Truth Table:");
        System.Console.WriteLine($"{isTrue}  && {isTrue}  :: {isTrue && isTrue}");
        System.Console.WriteLine($"{isTrue}  && {isFalse} :: {isTrue && isFalse}");
        System.Console.WriteLine($"{isFalse} && {isTrue}  :: {isFalse && isTrue}");
        System.Console.WriteLine($"{isFalse} && {isFalse} :: {isFalse && isFalse}");

        System.Console.WriteLine("\nOR Truth Table:");
        System.Console.WriteLine($"{isTrue}  || {isTrue}  :: {isTrue || isTrue}");
        System.Console.WriteLine($"{isTrue}  || {isFalse} :: {isTrue || isFalse}");
        System.Console.WriteLine($"{isFalse} || {isTrue}  :: {isFalse || isTrue}");
        System.Console.WriteLine($"{isFalse} || {isFalse} :: {isFalse || isFalse}");

        System.Console.WriteLine("\nNOT(!) Truth Table:");
        System.Console.WriteLine($"!{isTrue}  :: {!isTrue}");
        System.Console.WriteLine($"!{isFalse} :: {!isFalse}");

        // This line will prevent the console window from closing immediately.
        System.Console.ReadLine();
    }
}