#pragma warning disable 0219, 8600, 8604

public class Exercise2
{
    public static void Example()
    {
        // Example #2: COVARIANCE

        // Again we have three objects in the hierarchy object <- stream <- memorystream - but this time we have
        // an IEnumerable of each one
        IEnumerable<object> ieo = null;
        IEnumerable<Stream> ies = null;
        IEnumerable<MemoryStream> iems = null;

        // Here's the new method
        static void DoIEnumerableOfStream(IEnumerable<Stream> ies){ /* does stuff with an IEnumerable of Stream here... */ }

        // Method invocations - again try to work out which will compile and which won't before uncommenting them
        //DoIEnumerableOfStream(ieo);
        DoIEnumerableOfStream(ies);
        //DoIEnumerableOfStream(iems);
    }
}        