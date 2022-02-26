#pragma warning disable 0219, 8600, 8604

public class Exercise4
{
    public static void Example()
    {
        // Example #4: INVARIANCE

        // Same 3 types, but this time an IList of each
        IList<object> ilo = null;
        IList<Stream> ils = null;
        IList<MemoryStream> ilms = null;

        // Method accepts an IList of Stream
        static void DoListOfStream(IList<Stream> ils){ /* does stuff with an IList of Stream here... */ }

        //Method invocations - compare with results from first 3 exercises
        //DoListOfStream(ilo);
        DoListOfStream(ils);
        //DoListOfStream(ilms);
    }
}