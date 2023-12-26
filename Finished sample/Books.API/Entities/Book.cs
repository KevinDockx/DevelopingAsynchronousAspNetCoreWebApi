using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Books.API.Entities;

[Table("Books")]
public class Book(Guid id, Guid authorId, string title, string? description)
{
    [Key]
    public Guid Id { get; set; } = id;

    [Required]
    [MaxLength(150)]
    public string Title { get; set; } = title;

    [MaxLength(2500)]
    public string? Description { get; set; } = description;

    public Guid AuthorId { get; set; } = authorId;
    public Author Author { get; set; } = null!;
}