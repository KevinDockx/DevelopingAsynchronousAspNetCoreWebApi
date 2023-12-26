namespace Books.API.Models.External;

public class BookCoverDto(string id, byte[]? content)
{
    public string Id { get; set; } = id;
    public byte[]? Content { get; set; } = content;
}