using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delta.NearAcademy.Student;

[Table("Students")]
public class StudentEntity
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(300)]
    public string Email { get; set; } = string.Empty;
}
