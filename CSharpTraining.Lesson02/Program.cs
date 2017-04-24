class Program
{
    static void Main()
    {
        // Declare a variable named 'content' and initialize it with the string value of
        // "The sky is blue".  The type of the variable content is now "string".
        var content = "The sky is blue";

        // Pass the variable 'content' as a parameter to the 'WriteLine' method.
        System.Console.WriteLine(content);

        // Uncomment this line to view the 'type' of the 'content' variable.
        //System.Console.WriteLine(content.GetType());

        // This line will prevent the console window from closing immediately.
        System.Console.ReadLine();
    }
}