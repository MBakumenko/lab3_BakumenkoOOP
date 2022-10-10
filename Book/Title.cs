namespace Book
{
    public class Title
    {
        public string Content { get; set; }
        public void Show() => Console.WriteLine(Content);
    }
}
