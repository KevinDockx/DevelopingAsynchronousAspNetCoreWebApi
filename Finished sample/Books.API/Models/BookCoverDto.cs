namespace Books.API.Models;

public class BookCoverDto(string id)
{
    public string Id { get; set; } = id;

    //public byte[]? Content { get; set; }

    //public BookCoverDto(string id, byte[]? content)
    //{
    //    Id = id;
    //    Content = content;
    //}
}