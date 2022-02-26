#pragma warning disable 0219, 8600, 8604

public class Exercise5
{
    public static void Example()
    {
        // Example #5: Bonus exercise. Arrays!

        // Same 3 types, but this time an Array of each
        object[] a_o = null;
        Stream[] a_s = null;
        MemoryStream[] a_ms = null;

        // Method now accepts an array of Stream
        static void DoListOfStream(Stream[] a_s){ /* does stuff with an array of Stream here... */ }

        // Method invocations - compare with results from exercise 4. Are they the same, or different?
        // Did you expect them to be the same, or different - And is this a good thing, or not?
        //DoListOfStream(a_o);
        DoListOfStream(a_s);
        //DoListOfStream(a_ms);
    }
}