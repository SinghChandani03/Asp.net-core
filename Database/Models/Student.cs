using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("StudentName", TypeName = "varchar(30)")]
        public string Name { get; set; }

        [Required]
        [Column("Gender", TypeName = "varchar(30)")]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
