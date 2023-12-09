
namespace Lab04;

public class BookBuilder : IBookBuilder
{
    public string Title { get; set; }
    public string Author { get; set; }
    public List<string> Genres { get; set; }
    public DateTime PublicationDate { get; set; }
    public string Annotation { get; set; }
    public string Isbn { get; set; }
    public List<string> Tags { get; set; }

    public IBookBuilder SetTitle(string title)
    {
        Title = title;
        return this;
    }

    public IBookBuilder SetAuthor(string author)
    {
        Author = author;
        return this;
    }

    public IBookBuilder SetGenres(IEnumerable<string> genres)
    {
        Genres = genres.ToList();
        return this;
    }

    public IBookBuilder SetISBN(string isbn)
    {
        Isbn = isbn;
        return this;
    }

    public IBookBuilder SetPublicationDate(DateTime date)
    {
        PublicationDate = date;
        return this;
    }

    public IBookBuilder SetAnnotation(string annotation)
    {
        Annotation = annotation;
        return this;
    }

    public IBookBuilder SetTags(IEnumerable<string> tags)
    {
        Tags = tags.ToList();
        return this;
    }

    public Book Build()
    {
        return new Book(Title, Author, Genres, PublicationDate, Annotation, Isbn, Tags);
    }
}