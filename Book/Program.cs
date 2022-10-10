using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Grimgar of Fantasy and Ash", "Ao Jumonji", "Haruhiro awakens to darkness and amnesia, among a group of strangers who can only remember their own names...and nothing else.\r\n");
            book.Show();
        }
    }
}
