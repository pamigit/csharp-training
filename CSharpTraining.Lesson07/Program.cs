using System;

class Program
{
    static void Main()
    {
        // Int32 max/min values in binary representation
        // 0111 1111 1111 1111 1111 1111 1111 1111 |  2147483647 | (2^31) - 1
        // 1000 0000 0000 0000 0000 0000 0000 0000 | -2147483648 | -2^31

        // Int64
        // 0000 0000 0000 0000 0000 0000 0000 0000 0111 1111 1111 1111 1111 1111 1111 1111 
        // 1000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 

        // ===================================================================================
        Console.WriteLine("Compare/Calculate Max Int");

        var maxInt = int.MaxValue;
        var maxIntCalulated = Math.Pow(2.0, 31.0) - 1;

        if (maxInt == maxIntCalulated)
        {
            Console.WriteLine($"Max int is: {maxInt}");
            Console.WriteLine($"(2^31) - 1: {maxIntCalulated}");
        }

        //// ===================================================================================
        //Console.WriteLine("\nMax/Min Int in binary");
        //Console.WriteLine($"Max int in binary: {Convert.ToString(int.MaxValue, 2)}");
        //Console.WriteLine($"Min int in binary: {Convert.ToString(int.MinValue, 2)}");

        //// ===================================================================================
        //Console.WriteLine("\nExplicit Cast to narrower type (long to int)");
        //var aLongNum = 2147483648L;
        //var anIntNum = (int)aLongNum;
        //Console.WriteLine(anIntNum); // -2147483648

        //// ===================================================================================
        //Console.WriteLine("\nUsing the Convert utility class");
        //try
        //{
        //    var strInt = "101";
        //    var intStr = Convert.ToInt32(strInt);
        //    Console.WriteLine($"{strInt} converts to {intStr}");
        //}
        //catch (Exception) { }
        
        // This line will prevent the console window from closing immediately.
        System.Console.ReadLine();
    }
}