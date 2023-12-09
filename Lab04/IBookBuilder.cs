

namespace Lab04;

public interface IBookBuilder
{
    public IBookBuilder SetTitle(string title);
    public IBookBuilder SetAuthor(string author);
    public IBookBuilder SetGenres(IEnumerable<string> genres);
    public IBookBuilder SetISBN(string isbn);
    public IBookBuilder SetPublicationDate(DateTime date);
    public IBookBuilder SetAnnotation(string annotation);
    public IBookBuilder SetTags(IEnumerable<string> tags);
    public Book Build();
}