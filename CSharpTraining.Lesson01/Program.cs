// Every method in C# must be inside of a class.
class Program
{
    // All console applications must have a "Main" function in order to run.
    // Hit F5 to run the application.
    static void Main()
    {
        // System is a namespace.
        // Console is a class.
        // WriteLine is a static method.
        // "Hello" is a string.
        // The "Hello" string is a parameter of the static method WriteLine.
        System.Console.WriteLine("Hello");

        // Uncomment the following lines to see the "types" of the parameters.
        //System.Console.WriteLine("Hello".GetType());
        //System.Console.WriteLine(1.GetType());
        //System.Console.WriteLine(true.GetType());

        // This line will prevent the console window from closing immediately.
        System.Console.ReadLine();
    }
}