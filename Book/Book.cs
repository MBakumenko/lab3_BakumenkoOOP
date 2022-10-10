namespace Book
{
    public class Book
    {
        public Book(string title, string author, string content)
        {
            BookTitle.Content = title;
            BookAuthor.Name = author;
            BookContent.Text = content;
        }

        public Title BookTitle { get; set; } = new Title();
        public Author BookAuthor { get; set; } = new Author();
        public Content BookContent { get; set; } = new Content();

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            BookTitle.Show();
            Console.ForegroundColor = ConsoleColor.Yellow;
            BookAuthor.Show();
            Console.ForegroundColor = ConsoleColor.Cyan;
            BookContent.Show();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
