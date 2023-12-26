namespace Books.API.Models;

public class BookWithCoversDto(Guid id,
    string authorName,
    string title,
    string? description) : BookDto(id, authorName, title, description)
{
    public IEnumerable<BookCoverDto> BookCovers { get; set; }
        = new List<BookCoverDto>();
}