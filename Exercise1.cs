#pragma warning disable 0219, 8600, 8604

public class Exercise1
{
    public static void Example()
    {
        // Example #1: - a method that accepts a simple type

        // We start with three objects that sit in the type hierarchy: object <- stream <- memorystream

        object o = null;
        Stream s = null;
        MemoryStream ms = null;

        // Now let's attempt to pass each of those three objects into a method
        // Here's the method - Notice the type of the parameter in the method signature

        static void DoStream(Stream s){ /* does stuff with a Stream here... */ }

        // The challenge: BEFORE uncommenting the calls, work out which (if any) will compile, which won't, & why?
        // (This isn't a trick question - but it's setting up the pattern for the subsequent exercises)

        //DoStream(o);
        DoStream(s);
        //DoStream(ms);
    }
}        