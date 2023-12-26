namespace Books.API.Models;

public class BookDto(Guid id,
    string authorName,
    string title,
    string? description)
{
    public Guid Id { get; set; } = id;

    public string AuthorName { get; set; } = authorName;

    public string Title { get; set; } = title;

    public string? Description { get; set; } = description;
}
