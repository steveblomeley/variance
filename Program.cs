public class Program
{
    public static void Main(string[] _)
    {
        //Some actual runnable code to illustrate how the (unexpected?) covariance of arrays in C# can bite you.
        var fileStreams = new FileStream[5];
        DoStuff(fileStreams);

        System.Console.WriteLine("Bet we didn't get to here, did we?");
    }

    public static void DoStuff(Stream[] streams)
    {
        //Lets add a memory stream to our array of streams - that's got to be safe, right?
        if (streams != null) {
            streams[0] = new MemoryStream();
        }
    }
}