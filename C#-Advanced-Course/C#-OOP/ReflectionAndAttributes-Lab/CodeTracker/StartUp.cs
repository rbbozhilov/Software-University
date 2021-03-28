namespace AuthorProblem
{
    [Author("Gosho")]
    public class StartUp
    {
        [Author("Niki")]
        static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
