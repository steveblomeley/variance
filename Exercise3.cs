#pragma warning disable 0219, 8600, 8604

public class Exercise3
{
    public static void Example()
    {
        // Example #3: CONTRAVARIANCE

        // Our 3 objects this time are each an Action of the same three types as before
        Action<object> aco = null;
        Action<Stream> acs = null;
        Action<MemoryStream> acms = null;

        // New method accepts an ACTION OF stream
        static void DoActionOfStream(Action<Stream> acs){ /* does stuff with an Action of Stream here... */ }

        // 3 method invocations - again, think about each one before uncommenting
        // Compare with the results from the first two exercises - what's different? And WHY??
        //DoActionOfStream(aco);
        DoActionOfStream(acs);
        //DoActionOfStream(acms);
    }
}    