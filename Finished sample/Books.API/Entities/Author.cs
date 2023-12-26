using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Books.API.Entities;


[Table("Authors")]
public class Author(Guid id, string firstName, string lastName)
{
    [Key]
    public Guid Id { get; set; } = id;

    [Required]
    [MaxLength(150)]
    public string FirstName { get; set; } = firstName;

    [Required]
    [MaxLength(150)]
    public string LastName { get; set; } = lastName;
}