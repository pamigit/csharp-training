using System;   // Now we don't have to type out things like System.Console (the fully qualified namespace of that type)

class Program
{
    static void Main()
    {
        var date = DateTime.Now;
        //date = null;    // ERROR!
        Console.WriteLine($"date is {date}");

        // The size of the memory space that the DateTime value type can be stored in is 'fixed'
        Console.WriteLine($"Max date is {DateTime.MaxValue}");

        var guid = Guid.NewGuid();
        //guid = null;    // ERROR!
        Console.WriteLine($"guid is {guid}");

        //DateTime? nullableDate = null;
        //if (nullableDate == null)
        //{
        //    Console.WriteLine($"nullableDate is {nullableDate.GetValueOrDefault()}");
        //}

        //// Using the null-coalescing operator.
        //// https://msdn.microsoft.com/en-us/library/ms173224.aspx
        //nullableDate = nullableDate ?? DateTime.Now;
        //if (nullableDate.HasValue)
        //{
        //    Console.WriteLine($"nullableDate is {nullableDate.Value}");
        //    //Console.WriteLine($"nullableDate is {nullableDate}");
        //}

        // This line will prevent the console window from closing immediately.
        System.Console.ReadLine();
    }
}