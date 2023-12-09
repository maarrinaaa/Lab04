

namespace Lab04;

public interface ILibrary
{
    public IEnumerable<Book> SearchByTitle(string title);
    public IEnumerable<Book> SearchByAuthor(string author);
    public IEnumerable<Book> SearchByISBN(string isbn);
    public IEnumerable<Book> SearchByTags(IEnumerable<string> tags);
}