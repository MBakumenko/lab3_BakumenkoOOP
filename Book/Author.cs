namespace Book
{
    public class Author
    {
        public string Name { get; set; }
        public void Show() => Console.WriteLine(Name);
    }
}