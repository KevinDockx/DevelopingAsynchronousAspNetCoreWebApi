namespace Books.API.Models;

public class BookForCreationDto(Guid authorId,
    string title,
    string? description)
{
    public Guid AuthorId { get; set; } = authorId;

    public string Title { get; set; } = title;

    public string? Description { get; set; } = description;
}